
namespace Places.Domain.Interfaces.Repositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        public Task<Reservation?> FindByCreditCardPaymentId(string creditCardPaymentId);
        public Task ProcessPayment(int reservationId, ReservationCreditCardPayment paymentRequest);
    }

}