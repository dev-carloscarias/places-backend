using Places.Application.Dtos.Recurrente.WebHook;
using System.Text.Json;
using Svix;

namespace Places.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PaymentsWebHookController : ControllerBase
    {
        private readonly IRecurrenteWebHookProcessorService _recurrenteWebHookProcessorService;
        private readonly string _signingSecret;
        public PaymentsWebHookController(IRecurrenteWebHookProcessorService recurrenteWebHookProcessorService, IConfiguration configuration)
        {

            _recurrenteWebHookProcessorService = recurrenteWebHookProcessorService;
            _signingSecret = configuration.GetRequiredSection("Recurrente:SigningSecret").Value!;
        }
        [HttpPost]
        [Route("reservations")]
        public async Task<IActionResult> ProcessReservationPayment()
        {
            var payload = await new StreamReader(Request.Body).ReadToEndAsync();
            var headers = HeadersToCollection(Request.Headers);

            try
            {
                var webhook = new Webhook(_signingSecret);
                webhook.Verify(payload, headers);

                var request = System.Text.Json.JsonSerializer.Deserialize<RecurrentePaymentNotificationDto>(payload);
                await _recurrenteWebHookProcessorService.ProcessReservationCreditCardPaymentNotification(request!);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        private WebHeaderCollection HeadersToCollection(IHeaderDictionary headers)
        {
            var collection = new WebHeaderCollection();

            foreach (var header in headers)
            {
                foreach (var value in header.Value)
                {
                    collection.Add(header.Key, value);
                }
            }

            return collection;
        }

    }
}
