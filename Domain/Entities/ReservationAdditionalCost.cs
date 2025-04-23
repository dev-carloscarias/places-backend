
namespace Places.Domain.Entities
{
    public class ReservationAdditionalCost : EntityBase
    {
        public int Quantity { get; set; }
        public decimal AgreedPrice { get; set; }
        public int AdditionalCostId { get; set; }
        public virtual AdditionalCost AdditionalCost { get; set; } = null!;
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; } = null!;
    }
}