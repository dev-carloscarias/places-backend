using AutoMapper;
using Places.Application.Dtos.Recurrente.WebHook;
using Places.Application.Dtos.Reservation.Payment;

namespace Places.Infrastructure.Services
{
    public class RecurrenteWebHookProcessorService : IRecurrenteWebHookProcessorService
    {
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;
        public RecurrenteWebHookProcessorService(IReservationService reservationService, IMapper mapper)
        {
            _reservationService = reservationService;   
            _mapper = mapper;
        }
        public async Task ProcessReservationCreditCardPaymentNotification(RecurrentePaymentNotificationDto request)
        {
            if(request.EventType == RecurrenteIntentEventTypes.creditCardPaymentSucceeded)
            {
                var payment = _mapper.Map<CreditCardReservationPayment>(request);
               await _reservationService.ProccessPayment(payment);
            }
            
        }
    }

    public static class RecurrenteIntentEventTypes
    {
        public static string creditCardPaymentFailed = "payment_intent.failed";
        public static string creditCardPaymentSucceeded = "payment_intent.succeeded";
    }
}
