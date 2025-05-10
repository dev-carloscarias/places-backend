using Places.Application.Dtos.Recurrente.WebHook;

namespace Places.Application.Interfaces
{
    public interface IRecurrenteWebHookProcessorService
    {
        public Task ProcessReservationCreditCardPaymentNotification(RecurrentePaymentNotificationDto request);
    }
}
