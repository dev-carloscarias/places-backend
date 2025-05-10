namespace Places.Application.Dtos.CreditCardPayment
{
    public class CreditCardResponseHandler
    {
        public bool Success { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
    }
}
