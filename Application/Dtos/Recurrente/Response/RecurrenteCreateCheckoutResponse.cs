using System.Text.Json.Serialization;

namespace Places.Application.Dtos.Recurrente.Response
{
    public class RecurrenteCreateCheckoutResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("checkout_url")]
        public string CheckoutUrl { get; set; } = string.Empty;
    }
}
