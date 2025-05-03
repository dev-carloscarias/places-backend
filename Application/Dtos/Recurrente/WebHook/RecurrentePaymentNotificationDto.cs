using System.Text.Json.Serialization;
namespace Places.Application.Dtos.Recurrente.WebHook
{

    public partial class RecurrentePaymentNotificationDto
    {
        [JsonPropertyName("amount_in_cents")]
        public long AmountInCents { get; set; }

        [JsonPropertyName("api_version")]
        public DateTimeOffset ApiVersion { get; set; }

        [JsonPropertyName("checkout")]
        public Checkout Checkout { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("event_type")]
        public string EventType { get; set; }

        [JsonPropertyName("failure_reason")]
        public object FailureReason { get; set; }

        [JsonPropertyName("fee")]
        public long Fee { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }

        [JsonPropertyName("product")]
        public PurpleProduct Product { get; set; }

        [JsonPropertyName("products")]
        public List<ProductElement> Products { get; set; }

        [JsonPropertyName("tax_invoice_url")]
        public object TaxInvoiceUrl { get; set; }

        [JsonPropertyName("used_presaved_payment_method")]
        public bool UsedPresavedPaymentMethod { get; set; }

        [JsonPropertyName("vat_withheld")]
        public long VatWithheld { get; set; }

        [JsonPropertyName("vat_withheld_currency")]
        public string VatWithheldCurrency { get; set; }
    }

    public partial class Checkout
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }

        [JsonPropertyName("payment_method")]
        public object PaymentMethod { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("transfer_setups")]
        public List<object> TransferSetups { get; set; }
    }


    public partial class Payment
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("paymentable")]
        public Paymentable Paymentable { get; set; }
    }

    public partial class Paymentable
    {
        [JsonPropertyName("address")]
        public object Address { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("phone_number")]
        public object PhoneNumber { get; set; }

        [JsonPropertyName("tax_id")]
        public string TaxId { get; set; }

        [JsonPropertyName("tax_name")]
        public object TaxName { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public partial class Customer
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public partial class PurpleProduct
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public partial class ProductElement
    {
        [JsonPropertyName("address_requirement")]
        public string AddressRequirement { get; set; }

        [JsonPropertyName("billing_info_requirement")]
        public string BillingInfoRequirement { get; set; }

        [JsonPropertyName("cancel_url")]
        public object CancelUrl { get; set; }

        [JsonPropertyName("custom_terms_and_conditions")]
        public string CustomTermsAndConditions { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("metadata")]
        public ProductMetadata Metadata { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone_requirement")]
        public string PhoneRequirement { get; set; }

        [JsonPropertyName("prices")]
        public List<Price> Prices { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("storefront_link")]
        public Uri StorefrontLink { get; set; }

        [JsonPropertyName("success_url")]
        public object SuccessUrl { get; set; }
    }

    public partial class ProductMetadata
    {
    }

    public partial class Price
    {
        [JsonPropertyName("amount_in_cents")]
        public long AmountInCents { get; set; }

        [JsonPropertyName("billing_interval")]
        public string BillingInterval { get; set; }

        [JsonPropertyName("billing_interval_count")]
        public long BillingIntervalCount { get; set; }

        [JsonPropertyName("charge_type")]
        public string ChargeType { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("free_trial_interval")]
        public string FreeTrialInterval { get; set; }

        [JsonPropertyName("free_trial_interval_count")]
        public long FreeTrialIntervalCount { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("periods_before_automatic_cancellation")]
        public object PeriodsBeforeAutomaticCancellation { get; set; }
    }
}

