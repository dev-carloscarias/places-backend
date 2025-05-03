using Places.Application.Dtos.Reservation.Availability;
using Places.Application.Dtos.Reservation.Create;
using Places.Application.Dtos.Reservation.Created;
using Places.Application.Dtos.Reservation.Payment;

namespace Places.Application.Interfaces
{
    public interface IReservationService
    {
        public Task<CreatedReservationDto> CreateReservation(CreateReservationDTO reservationDTO);
        public Task<CreatedReservationDto> GetReservationById(int reservationId);
        public Task<AvailabilityResponse> VerifyAvailability(VerifySiteAvailabilityDto request);
        public Task ProccessPayment(CreditCardReservationPayment payment);
    }
}