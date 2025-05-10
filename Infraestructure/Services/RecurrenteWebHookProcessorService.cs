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
            var payment = _mapper.Map<ReservationPaymentDto>(request);

            if (request.EventType == RecurrenteIntentEventTypes.creditCardPaymentSucceeded
                || request.EventType == RecurrenteIntentEventTypes.transferPaymentSucceeded
                )
            {
                await _reservationService.ProccessPayment(payment);
                return;
            }

            if (request.EventType == RecurrenteIntentEventTypes.transferPaymentPending)
            {
                await _reservationService.ProccessPendingPayment(payment);
                return;
            }

            if (request.EventType == RecurrenteIntentEventTypes.creditCardPaymentFailed
                || request.EventType == RecurrenteIntentEventTypes.transferPaymentFailed)
            {
                await _reservationService.ProccessFailedPayment(payment);
                return;
            }

        }
    }

    public static class RecurrenteIntentEventTypes
    {
        public static string creditCardPaymentFailed = "payment_intent.failed";
        public static string creditCardPaymentSucceeded = "payment_intent.succeeded";
        public static string transferPaymentFailed = "bank_transfer_intent.failed";
        public static string transferPaymentPending = "bank_transfer_intent.pending";
        public static string transferPaymentSucceeded = "bank_transfer_intent.succeeded";
    }
}
