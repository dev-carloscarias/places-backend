using Places.Application.Dtos.CreditCardPayment;
using Places.Application.Dtos.Reservation.Payment;

namespace Places.Application.Interfaces
{
    public interface ICreditCardPayment
    {
        public Task<CreditCardResponseHandler> ProcessCreditCardPayment(CreateCreditCardReservationPayment creditCardPayment);
    }
}
