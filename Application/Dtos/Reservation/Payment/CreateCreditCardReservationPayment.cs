namespace Places.Application.Dtos.Reservation.Payment
{
    public class CreateCreditCardReservationPayment
    {
        public string SuccessUrl { get; set; } = string.Empty;
        public string CancelUrl { get; set; } = string.Empty;
        public string ReservationId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public long UserId { get; set; }
        public string Currency { get; set; } = string.Empty;
        public decimal TotalAmmount { get; set; }
        public string ReservationImgUrl { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
