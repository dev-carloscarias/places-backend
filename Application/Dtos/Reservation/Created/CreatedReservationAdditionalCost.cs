using Places.Application.Dtos.Reservation.Create;

namespace Places.Application.Dtos.Reservation.Created
{
    public class CreatedReservationAdditionalCost : ReservationAdditionalCostDto
    {
        public AdditionalCostDto AdditionalCost { get; set; } = null!;
    }
}
