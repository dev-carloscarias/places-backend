using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Places.Application.Dtos;
using Places.Application.Dtos.Reservation.Availability;
using Places.Application.Dtos.Reservation.Create;
using Places.Application.Dtos.Reservation.Created;
using Places.Application.Dtos.Reservation.List;
using Places.Application.Dtos.Reservation.Payment;
using Places.Application.Interfaces;
using Places.Domain.Entities;
using Places.Domain.Interfaces.Repositories;

namespace Places.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly ISiteRepository _siteRepository;
        private readonly ICurrentUserService _currentUserService;
        private readonly IMapper _mapper;
        private readonly ICreditCardPayment _creditCardPaymentService;
        private readonly ILogger _logger;
        private readonly string _environmentUrl;
        private readonly IEmailService _emailService;
        private readonly IHubContext<NotificationHub> _notificationHubContext;
        private readonly IUserRepository _userRepository;
        private readonly INotificationsService _notificationsService;
        public ReservationService(IReservationRepository reservationRepository,
            ISiteRepository siteRepository,
            ICurrentUserService currentUserService,
            IMapper mapper,
            ICreditCardPayment creditCardPaymentService,
            ILogger<ReservationService> logger,
            IConfiguration configuration,
            IEmailService emailService,
            IHubContext<NotificationHub> notificationHubContext,
            IUserRepository userRepository,
            INotificationsService notificationsService
            )
        {
            _reservationRepository = reservationRepository;
            _siteRepository = siteRepository;
            _currentUserService = currentUserService;
            _mapper = mapper;
            _creditCardPaymentService = creditCardPaymentService;
            _logger = logger;
            _environmentUrl = configuration.GetRequiredSection("Recurrente:environmentUrl").Value!;
            _emailService = emailService;
            _notificationHubContext = notificationHubContext;
            _userRepository = userRepository;
            _notificationsService = notificationsService;
        }
        public async Task<CreatedReservationDto> CreateReservation(CreateReservationDTO reservationDTO)
        {

            var site = await _siteRepository.GetByIdAsync(reservationDTO.SiteId);
            if (site == null)
            {
                throw new BadRequestException("Sitio no encontrado");
            }

            if (reservationDTO.ReservationDate <= DateTime.Now)
            {
                // TODO respuesta si la reserva es de una fecha pasada
                throw new BadRequestException("No puedes reservar en una fecha pasada");
            }

            if (reservationDTO.TotalAdults == 0 && reservationDTO.TotalChildren == 0)
            {
                // TODO respuesta si no tiene al menos una persona invitada
                throw new BadRequestException("Tienes que añadir al menos a un adulto o un menor");
            }
            if (reservationDTO.SpecialPackageId != null && reservationDTO.SpecialPackageId != 0 && (reservationDTO.SpecialPackageQuantity == null || reservationDTO.SpecialPackageQuantity <= 0))
            {
                // TODO si manda paquete especial pero sin la cantidad
                throw new BadRequestException("Se debe añadir la cantidad de paquetes especiales");
            }

            var request = new VerifySiteAvailabilityDto
            {
                ReservationDate = reservationDTO.ReservationDate,
                SiteId = site.Id,
                TotalAdults = reservationDTO.TotalAdults,
                TotalChildren = reservationDTO.TotalChildren,
            };

            var availabilityResponse = await CheckAvailability(request);
            if (!availabilityResponse.Available)
            {
                throw new BadRequestException(availabilityResponse.Message);
            }

            Reservation reservation = new Reservation
            {
                SiteId = reservationDTO.SiteId,
                CreatedBy = (await _currentUserService.GetCurrentUserIdAsync())?.Id ?? 0,
                CreatedAt = DateTime.Now,
                IsActive = true,
                AdultAgreedPrice = site.AdultPrice,
                ChildAgreedPrice = site.ChildPrice,
                ReservationDate = reservationDTO.ReservationDate,
                ReservationPaymentType = ReservationPaymentType.CreditCard,
                TotalAdults = reservationDTO.TotalAdults,
                TotalChildren = reservationDTO.TotalChildren,
                ReservationState = ReservationState.Created,
                UpdatedAt = DateTime.Now,
            };

            if (reservationDTO.AdditionalCosts.Count() > 0)
            {
                List<ReservationAdditionalCost> additionalCostsList = [];
                foreach (var a in reservationDTO.AdditionalCosts)
                {
                    var cost = site.AdditionalCosts.FirstOrDefault(c => c.Id == a.AdditionalCostId);
                    if (cost == null)
                    {
                        // TODO error si el costo enviado no existe
                        throw new BadRequestException("El costo adicional no existe");
                    }
                    additionalCostsList.Add(new ReservationAdditionalCost
                    {
                        AdditionalCostId = a.AdditionalCostId,
                        AgreedPrice = cost.Price,
                        Quantity = a.Quantity,
                    });
                }
                reservation.AdditionalCosts = additionalCostsList;
            }

            if (reservationDTO.SelectedTransportOptions.Count() > 0)
            {
                List<ReservationSelectedTransportOption> transportOptionList = [];
                foreach (var a in reservationDTO.SelectedTransportOptions)
                {
                    var cost = site.SelectedTransportOptions.FirstOrDefault(c => c.Id == a.SelectedTransportOptionId);
                    if (cost == null)
                    {
                        // TODO error si el costo enviado no existe
                        throw new BadRequestException("El transporte adicional no existe");
                    }
                    transportOptionList.Add(new ReservationSelectedTransportOption
                    {
                        SelectedTransportOptionId = a.SelectedTransportOptionId,
                        Quantity = a.Quantity,
                        AgreedPrice = (decimal)cost.Price,
                    });
                }
                reservation.SelectedTransportOptions = transportOptionList;
            }

            if (reservationDTO.SpecialPackageId != null)
            {
                reservation.SpecialPackageId = reservationDTO.SpecialPackageId;
                reservation.SpecialPackageQuantity = reservationDTO.SpecialPackageQuantity;
                reservation.SpecialPackageAgreedPrice = site.SpecialPackage.Price;
            }
            decimal totalAmmountPeople = (reservation.TotalAdults * reservation.AdultAgreedPrice) + (reservation.TotalChildren * reservation.ChildAgreedPrice);
            decimal totalAmmountAdditionals = reservation.AdditionalCosts.Sum(c => c.Quantity * c.AgreedPrice);
            decimal totalAmmountVehicles = reservation.SelectedTransportOptions.Sum(c => c.Quantity * c.AgreedPrice);
            decimal totalAmmountSpecialPackage = reservation.SpecialPackageId == null ? 0 : (decimal)(reservation.SpecialPackageQuantity * reservation.SpecialPackageAgreedPrice)!;
            decimal totalAmmount = totalAmmountPeople + totalAmmountAdditionals + totalAmmountVehicles
                 + totalAmmountSpecialPackage;
            var commision = totalAmmount * (decimal)0.16;
            reservation.TotalAmmount = totalAmmount;
            reservation.Commision = commision;

            var newReservation = await _reservationRepository.AddAsync(reservation);

            var creditCardReservationPayment = new CreateCreditCardReservationPayment
            {
                SuccessUrl = _environmentUrl + "/user-menu/reservaciones",
                CancelUrl = _environmentUrl + "/user-menu/reservaciones",
                Currency = "GTQ",
                Name = "Reservación " + site.Title,
                Quantity = 1,
                UserId = newReservation.CreatedBy,
                ReservationId = newReservation.Id.ToString(),
                ReservationImgUrl = site.DataFiles.ToList()[0].Path,
                TotalAmmount = newReservation.TotalAmmount + newReservation.Commision,
            };
            var response = await _creditCardPaymentService.ProcessCreditCardPayment(creditCardReservationPayment);

            if (response == null || !response.Success)
            {
                newReservation.IsActive = false;
                await _reservationRepository.UpdateAsync(newReservation);
                throw new BadRequestException("Ocurrió un error al generar el metodo de pago");
            }

            newReservation.CreditCardPaymentId = response.Id;
            newReservation.CreditCardPaymentUrl = response.Url;
            newReservation.ReservationState = ReservationState.PendingPayment;

            await _reservationRepository.UpdateAsync(newReservation);


            var siteDto = _mapper.Map<SiteDto>(site);

            var createdReservation = _mapper.Map<CreatedReservationDto>(newReservation);
            // createdReservation.Site = siteDto;
            return createdReservation;
        }

        public async Task<CreatedReservationDto> GetReservationById(int reservationId)
        {
            var reservations = await _reservationRepository.FindByPredicate(c => c.Id == reservationId);
            if (reservations != null && reservations.Count > 0)
                return _mapper.Map<CreatedReservationDto>(reservations.FirstOrDefault());
            throw new BadRequestException("Reservación no encontrada");
        }

        public async Task<AvailabilityResponse> CheckAvailability(VerifySiteAvailabilityDto request)
        {
            var site = await _siteRepository.GetByIdAsync(request.SiteId);
            if (site == null)
            {
                return new AvailabilityResponse
                {
                    Available = false,
                    Message = "Sitio no encontrado",
                };
            }

            var reservationDateIsNotAvailableOnSechedules = site.Availabilities.
              Where(h => h.DayOfWeek == request.ReservationDate.DayOfWeek)
              .Count() <= 0;
            var bloquedDays = site.SelectedDates
                .Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
            var reservationDateIsBloqued = false;
            if (bloquedDays.Count > 0)
            {

                var bloquedDaysDates = bloquedDays.Select(d => DateTime.ParseExact(d, "yyyy-MM-dd", CultureInfo.InvariantCulture)).ToList();
                reservationDateIsBloqued = bloquedDaysDates.Any(c => c.Date == request.ReservationDate.Date);
            }

            if (reservationDateIsNotAvailableOnSechedules || reservationDateIsBloqued)
            {
                return new AvailabilityResponse
                {
                    Available = false,
                    Message = "Fecha no disponible",
                };
            }

            var capacity = site.Capacity;
            var reservas = await _reservationRepository.FindAllAsync(c => c.IsActive && c.SiteId == site.Id
            && c.ReservationDate.Date == request.ReservationDate.Date && c.ReservationState == ReservationState.Approved);
            var totalReservado = reservas.Sum(c => (c.TotalAdults + c.TotalChildren));
            if (capacity > 0 && capacity <= (totalReservado + request.TotalChildren + request.TotalAdults))
            {
                return new AvailabilityResponse
                {
                    Available = false,
                    Message = "Lo sentimos hemos llegado a la maxima capacidad",
                };
            }
            return new AvailabilityResponse
            {
                Available = true,
            };
        }

        public async Task<AvailabilityResponse> VerifyAvailability(VerifySiteAvailabilityDto request)
        {
            var response = await CheckAvailability(request);
            if (!response.Available)
            {
                throw new BadRequestException(response.Message);
            }
            return response;
        }

        public async Task ProccessPayment(ReservationPaymentDto paymentRequest)
        {
            var reservation = await _reservationRepository.FindByCreditCardPaymentId(paymentRequest.Id);
            if (reservation == null)
            {
                _logger.LogError("Pago recibido id " + paymentRequest.Id + " pero no fue encontrada la reservación asociada a ese pago");
                throw new BadRequestException("Reservación no encontrada");
            }


            if (reservation.ReservationState == ReservationState.PendingPayment
                || reservation.ReservationState == ReservationState.PendingPayment)
            {
                var payment = new ReservationPayment
                {
                    ReservationId = reservation.Id,
                    ProcessedBy = paymentRequest.ProcessedBy,
                    Currency = paymentRequest.Currency,
                    CreatedAt = DateTimeOffset.Now,
                    Ammount = paymentRequest.Ammount
                };
                await _reservationRepository.ProcessPayment(reservation.Id, payment);

                var site = reservation.Site!;
                var reservationUser = reservation.CreatedByUser;
                string ownerEmail = site.User.Email!;
                var owner = await _userRepository.GetByIdAsync(site.UserId);
                int ownerId = owner.Id;
                string userEmail = reservationUser.Email;
                int userId = reservation.CreatedBy;

                var ownerEmailMessage = new StringBuilder().
                    Append($"¡Felicidades! Tu sitio {site.Title} ha sido reservado.")
                    .Append("\n")
                    .Append("Sitio reservado por:")
                    .Append(reservationUser.FirstName + " " + reservationUser.LastName)
                    .Append("\n")
                    .Append($"Total reserva: {reservation.TotalAmmount} GTQ")
                    .Append("\n")
                    .Append($"Fecha de reserva: {reservation.ReservationDate.ToString("YY/MM/dd")}")
                    .Append("\n")
                    .Append($"Total adultos: {reservation.TotalAdults}")
                    .Append("\n")
                    .Append($"Total niños: {reservation.TotalChildren}")
                    .Append("\n")
                    .Append($"Paquete especial: {(
                        reservation?.SpecialPackageId != null ?
                        reservation.SpecialPackageQuantity.ToString() + " " + reservation.SpecialPackage!.PackageName
                        : "No adquirido")}")
                    .Append("\n")
                    .Append($"Costo adicional: {(
                        reservation!.AdditionalCosts.Count() > 0 ?
                        string.Join(",", reservation.AdditionalCosts.Select((c) => c.Quantity + " - " + c.AdditionalCost.Name).ToList())
                        : "No adquirido"
                        )}")
                    .Append("\n")
                    .Append($"Transportes: {(
                    reservation.SelectedTransportOptions.Count() > 0 ?
                    string.Join(",", reservation.SelectedTransportOptions.Select((c) => c.Quantity + " - " + c.SelectedTransportOption!.TransportOption.Name).ToList()) :
                    "No adquirido"
                    )}")
                    .Append("\n")
                    .ToString();

                var userMessage = new StringBuilder()
                    .Append($"¡Felicidades! Tu reservación ha sido confirmada.").ToString();
                var res1 = await _emailService.SendOwnerReservationReceived(ownerEmail, ownerEmailMessage);
                var res2 = await _emailService.SendUserReservationApproved(userEmail, userMessage);

                var ownerNotificationMessage = "¡Felicidades! Tu sitio " + site.Title + " ha sido reservado por " +
                    reservationUser.FirstName + " " + reservationUser.LastName + ".";

                var userReservationNotification = new Notification
                {
                    UserId = reservationUser.Id,
                    profilePhoto = site.DataFiles
                      .OrderBy(df => df.FileOrder)
                      .Select(df => df.Path)
                      .FirstOrDefault(),
                    Message = userMessage,
                    Timestamp = DateTime.UtcNow
                };
                var userReservationconnectionId = ConnectionMapping.GetConnectionId(reservationUser.Id);
                if (!string.IsNullOrEmpty(userReservationconnectionId))
                {
                    await _notificationHubContext.Clients.Client(userReservationconnectionId)
                        .SendAsync("ReceiveNotification", userReservationNotification);
                }
                await _notificationsService.CreateNotification(userReservationNotification);

                var ownerNotification = new Notification
                {
                    UserId = ownerId,
                    profilePhoto = site.DataFiles
                      .OrderBy(df => df.FileOrder)
                      .Select(df => df.Path)
                      .FirstOrDefault(),
                    Message = ownerNotificationMessage,
                    Timestamp = DateTime.UtcNow
                };
                var ownerConnectionId = ConnectionMapping.GetConnectionId(site.UserId);
                if (!string.IsNullOrEmpty(ownerConnectionId))
                {
                    await _notificationHubContext.Clients.Client(ownerConnectionId)
                        .SendAsync("ReceiveNotification", ownerNotification);
                }
                await _notificationsService.CreateNotification(ownerNotification);


            }
        }

        public async Task<List<CreatedReservationDto>> GetUserReservations()
        {
            var currentUserId = (await _currentUserService.GetCurrentUserIdAsync())?.Id ?? 0;
            var list = await _reservationRepository
                .FindByPredicate(c => c.CreatedBy == currentUserId && c.IsActive);
            var ll = _mapper.Map<List<CreatedReservationDto>>(list);
            return ll;
        }

        public async Task ProccessPendingPayment(ReservationPaymentDto paymentRequest)
        {
            var reservation = await _reservationRepository.FindByCreditCardPaymentId(paymentRequest.Id);
            if (reservation == null)
            {
                _logger.LogError("Pago pendiente recibido id " + paymentRequest.Id + " pero no fue encontrada la reservación asociada a ese pago");
                throw new BadRequestException("Reservación no encontrada");
            }
            await _reservationRepository.ProcessPendingPayment(reservation.Id);
        }

        public async Task ProccessFailedPayment(ReservationPaymentDto paymentRequest)
        {
            var reservation = await _reservationRepository.FindByCreditCardPaymentId(paymentRequest.Id);
            if (reservation == null)
            {
                _logger.LogError("Pago fallido recibido id " + paymentRequest.Id + " pero no fue encontrada la reservación asociada a ese pago");
                throw new BadRequestException("Reservación no encontrada");
            }
            await _reservationRepository.ProcessPendingPayment(reservation.Id);
        }

        public async Task<List<CreatedReservationDto>> GetSiteReservations(int siteId)
        {
            var currentUserId = (await _currentUserService.GetCurrentUserIdAsync())?.Id ?? 0;
            var site = await _siteRepository.GetByIdAsync(siteId);
            if (site != null && site.CreatedBy != currentUserId)
            {
                throw new BadRequestException("No tienes permisos para ver las reservaciones de este sitio");
            }
            var list = await _reservationRepository
                .FindByPredicate(c => c.SiteId == siteId && c.IsActive && c.ReservationState == ReservationState.Approved);
            var mappedList = _mapper.Map<List<CreatedReservationDto>>(list);
            return mappedList;
        }

        public async Task<List<CreatedReservationDto>> GetAllApprovedReservations()
        {
            var roleId = (await _currentUserService.GetCurrentUserIdAsync())?.RoleId ?? -1;
            //
            if (roleId != 1)
            {
                throw new BadRequestException("No tienes permisos para ver las reservaciones");
            }

            var list = await _reservationRepository
                .FindByPredicate(c => c.IsActive && c.ReservationState == ReservationState.Approved);
            var mappedList = _mapper.Map<List<CreatedReservationDto>>(list);
            return mappedList;
        }

        public async Task DeleteReservation(int id)
        {
            var currentUser = (await _currentUserService.GetCurrentUserIdAsync())?.Id ?? -1;
            var reservation = await _reservationRepository.GetByIdAsync(id);
            if (reservation == null)
            {
                throw new BadRequestException("Reservación no encontrada");
            }
            if (reservation.CreatedBy != currentUser)
            {
                throw new BadRequestException("No tienes permisos para eliminar esta reservación");
            }
            if (reservation.ReservationState == ReservationState.Approved)
            {
                throw new BadRequestException("No puedes eliminar una reservación pagada");
            }
            reservation.IsActive = false;
            reservation.UpdatedAt = DateTime.Now;
            await _reservationRepository.UpdateAsync(reservation);
        }
    }
}