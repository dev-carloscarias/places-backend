using System.Text.Json.Serialization;

namespace Places.Application.Dtos.Recurrente.Request
{
    public class CreateCheckoutDto
    {
        [JsonPropertyName("items")]
        public List<RecurrenteItem> Items { get; set; } = [];

        [JsonPropertyName("success_url")]
        public string SuccessUrl { get; set; } = string.Empty;

        [JsonPropertyName("cancel_url")]
        public string CancelUrl { get; set; } = string.Empty;

        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class RecurrenteItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("amount_in_cents")]
        public decimal AmountInCents { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = string.Empty;

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("reservationId")]
        public string ReservationId { get; set; } = string.Empty;
    }
}
