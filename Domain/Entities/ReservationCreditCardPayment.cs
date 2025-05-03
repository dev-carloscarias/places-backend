namespace Places.Domain.Entities
{
    public class ReservationCreditCardPayment : EntityBase
    {
        public string ProcessedBy { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public decimal Ammount { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; } = null!;
    }
}
