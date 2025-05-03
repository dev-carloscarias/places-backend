using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Places.Application.Dtos.CreditCardPayment;
using Places.Application.Dtos.Recurrente.Request;
using Places.Application.Dtos.Recurrente.Response;
using Places.Application.Dtos.Reservation.Payment;

namespace Places.Infrastructure.Services
{
    public class RecurrenteService : ICreditCardPayment
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<RecurrenteService> _logger;
        public RecurrenteService(ILogger<RecurrenteService> logger)
        {
            _httpClient = new HttpClient();
            _logger = logger;
        }
        public async Task<CreditCardResponseHandler> ProcessCreditCardPayment(CreateCreditCardReservationPayment creditCardPayment)
        {
            string url = "https://app.recurrente.com/api/checkouts/";
            string xPublicKey = "pk_live_YL0fodyEQ0dvrH2Q2C9Bb4AsOFjDsjOUQpJP7abeWVddYSPo6WPNd3yGq";
            string xSecretKey = "sk_live_GKJTkz68GE9tXmeuS72IZ9LZmMgTCn3OCoavuyY8RsjETH3odHZf28Yzb";

            var recurrenteCreateCheckoutRequest = new CreateCheckoutDto
            {
                SuccessUrl = creditCardPayment.SuccessUrl,
                CancelUrl = creditCardPayment.CancelUrl,
                UserId = creditCardPayment.UserId.ToString(),
                Metadata = new Metadata
                {
                    ReservationId = creditCardPayment.ReservationId
                },
                Items = [
                    new RecurrenteItem{
                            Currency = creditCardPayment.Currency,
                            AmountInCents = (int)( creditCardPayment.TotalAmmount * (decimal)100),
                            ImageUrl = creditCardPayment.ReservationImgUrl,
                            Name = creditCardPayment.Name,
                            Quantity = creditCardPayment.Quantity,
                        }
                ]
            };
            var json = JsonSerializer.Serialize(recurrenteCreateCheckoutRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("X-PUBLIC-KEY", xPublicKey);
            _httpClient.DefaultRequestHeaders.Add("X-SECRET-KEY", xSecretKey);

            var response = await _httpClient.PostAsync(url, content);

            var res = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var checkout = JsonSerializer.Deserialize<RecurrenteCreateCheckoutResponse>(res)!;
                return new CreditCardResponseHandler
                {
                    Success = true,
                    Id = checkout.Id,
                    Url = checkout.CheckoutUrl,
                };
            }
            _logger.LogError(res);
            return new CreditCardResponseHandler { Success = false };
        }
    }
}
