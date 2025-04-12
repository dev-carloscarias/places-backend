
namespace Places.Domain.Entities
{
    public class ReservationSelectedTransportOption : EntityBase
    {
        public int Quantity { get; set; }
        public decimal AgreedPrice { get; set; }
        public int SelectedTransportOptionId { get; set; }
        public virtual SelectedTransportOption SelectedTransportOption { get; set; } = null!;
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; } = null!;
    }
}