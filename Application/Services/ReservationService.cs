using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Places.Application.Dtos.Reservation.Create;
using Places.Application.Dtos.Reservation.Created;
using Places.Domain.Entities;

namespace Places.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly ISiteRepository _siteRepository;
        private readonly ICurrentUserService _currentUserService;
        private readonly IMapper _mapper;
        public ReservationService(IReservationRepository reservationRepository, ISiteRepository siteRepository, ICurrentUserService currentUserService, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _siteRepository = siteRepository;
            _currentUserService = currentUserService;
            _mapper = mapper;
        }
        public async Task<CreatedReservationDto> CreateReservation(CreateReservationDTO reservationDTO)
        {
            var site = await _siteRepository.GetByIdAsync(reservationDTO.SiteId);
            if (site == null)
            {
                throw new BadRequestException(LanguageConst.IdNotFound);
            }

            if (reservationDTO.ReservationDate <= DateTime.Now)
            {
                // TODO respuesta si la reserva es de una fecha pasada
                throw new BadRequestException(LanguageConst.IdNotFound);
            }

            if (reservationDTO.TotalAdults == 0 && reservationDTO.TotalChildren == 0)
            {
                // TODO respuesta si no tiene al menos una persona invitada
                throw new BadRequestException(LanguageConst.IdNotFound);
            }
            if (reservationDTO.SpecialPackageId != null && reservationDTO.SpecialPackageId != 0 && (reservationDTO.SpecialPackageQuantity == null || reservationDTO.SpecialPackageQuantity <= 0))
            {
                // TODO si manda paquete especial pero sin la cantidad
                throw new BadRequestException(LanguageConst.IdNotFound);
            }

            var reservationDateIsNotAvailableOnSechedules = site.Availabilities.
                Where(h => h.DayOfWeek == reservationDTO.ReservationDate.DayOfWeek)
                .Count() <= 0;
            var bloquedDays = site.SelectedDates
                .Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
            var reservationDateIsBloqued = false;
            if (bloquedDays.Count > 0)
            {

                var bloquedDaysDates = bloquedDays.Select(d => DateTime.ParseExact(d, "yyyy-MM-ddd", CultureInfo.InvariantCulture)).ToList();
                reservationDateIsBloqued = bloquedDaysDates.Any(c => c.Date == reservationDTO.ReservationDate.Date);
            }
            if (reservationDateIsNotAvailableOnSechedules || reservationDateIsBloqued)
            {
                // TODO respuesta si no est� disponible la fecha
                throw new BadRequestException(LanguageConst.IdNotFound);
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
                ReservationPaymentType = ReservationPaymentType.Neonet,
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
                        throw new BadRequestException(LanguageConst.IdNotFound);
                    }
                    additionalCostsList.Add(new ReservationAdditionalCost
                    {
                        AdditionalCostId = a.AdditionalCostId,
                        AgreedPrice = cost.Price,
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
                        throw new BadRequestException(LanguageConst.IdNotFound);
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

            var newReservation = await _reservationRepository.AddAsync(reservation);


            var createdReservation = _mapper.Map<CreatedReservationDto>(site);
            return createdReservation;
        }
    }
}