
namespace Places.Domain.Interfaces.Repositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        public Task<Reservation?> FindByCreditCardPaymentId(string creditCardPaymentId);
        public Task ProcessPayment(int reservationId, ReservationPayment paymentRequest);
        public Task ProcessPendingPayment(int reservationId);
        public Task ProcessFailedPayment(int reservationId);
        public Task<List<Reservation>> FindByPredicate(Expression<Func<Reservation, bool>> predicate);
    }

}