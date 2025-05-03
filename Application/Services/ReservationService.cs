using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Places.Application.Dtos.Reservation.Availability;
using Places.Application.Dtos.Reservation.Create;
using Places.Application.Dtos.Reservation.Created;
using Places.Application.Dtos.Reservation.Payment;
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
        public ReservationService(IReservationRepository reservationRepository,
            ISiteRepository siteRepository,
            ICurrentUserService currentUserService,
            IMapper mapper,
            ICreditCardPayment creditCardPaymentService,
            ILogger<ReservationService> logger
            )
        {
            _reservationRepository = reservationRepository;
            _siteRepository = siteRepository;
            _currentUserService = currentUserService;
            _mapper = mapper;
            _creditCardPaymentService = creditCardPaymentService;
            _logger = logger;
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
                reservation.SpecialPackageId = reservation.SpecialPackageId;
                reservation.SpecialPackageQuantity = reservationDTO.SpecialPackageQuantity;
                reservation.SpecialPackageAgreedPrice = site.SpecialPackage.Price;
            }
            decimal totalAmmountPeople = (reservation.TotalAdults * reservation.AdultAgreedPrice) + (reservation.TotalChildren * reservation.ChildAgreedPrice);
            decimal totalAmmountAdditionals = reservation.AdditionalCosts.Sum(c => c.Quantity * c.AgreedPrice);
            decimal totalAmmountVehicles = reservation.SelectedTransportOptions.Sum(c => c.Quantity * c.AgreedPrice);
            decimal totalAmmountSpecialPackage = reservation.SpecialPackageId == null ? 0 : (reservation.SpecialPackageQuantity ?? 0 * reservation.SpecialPackageAgreedPrice ?? 0);
            decimal totalAmmount = totalAmmountPeople + totalAmmountAdditionals + totalAmmountVehicles
                + totalAmmountSpecialPackage;
            var commision = totalAmmount * (decimal)0.16;
            reservation.TotalAmmount = totalAmmount;
            reservation.Commision = commision;

            var newReservation = await _reservationRepository.AddAsync(reservation);

            var creditCardReservationPayment = new CreateCreditCardReservationPayment
            {
                SuccessUrl = "http://localhost:4200/reservation-details/" + newReservation.Id.ToString(),
                CancelUrl = "http://localhost:4200/reservation-details/" + newReservation.Id.ToString(),
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
            var reservation = await _reservationRepository.GetById(reservationId);
            if (reservation != null)
                return _mapper.Map<CreatedReservationDto>(reservation);
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
            if (capacity <= (totalReservado + request.TotalChildren + request.TotalAdults))
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

        public async Task ProccessPayment(CreditCardReservationPayment paymentRequest)
        {
            var reservation = await _reservationRepository.FindByCreditCardPaymentId(paymentRequest.Id);
            if (reservation == null) {
                _logger.LogError("Pago recibido id " + paymentRequest.Id + " pero no fue encontrada la reservación asociada a ese pago");
                throw new BadRequestException("Reservación no encontrada");
            }
            if(reservation.ReservationState == ReservationState.PendingPayment)
            {
                var payment = new ReservationCreditCardPayment
                {
                    ReservationId = reservation.Id,
                    ProcessedBy = paymentRequest.ProcessedBy,
                    Currency = paymentRequest.Currency,
                    CreatedAt = DateTimeOffset.Now,
                    Ammount = paymentRequest.Ammount
                };
                await _reservationRepository.ProcessPayment(reservation.Id, payment);
            }
        }
    }
}