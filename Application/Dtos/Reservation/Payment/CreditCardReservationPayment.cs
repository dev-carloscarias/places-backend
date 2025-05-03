namespace Places.Application.Dtos.Reservation.Payment
{
    public class CreditCardReservationPayment
    {
        public string Id { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public decimal Ammount { get; set; }
        public string ProcessedBy { get; set; } = string.Empty;
    }
}
