using Places.Domain.Define;
using Places.Domain.Exceptions;

namespace Places.Infrastructure.Repositories
{
    public class ReservationRespository : Repository<Reservation>, IReservationRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public ReservationRespository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Reservation?> FindByCreditCardPaymentId(string creditCardPaymentId)
        {
            return await _appDbContext.Reservations
                .FirstOrDefaultAsync(c => c.CreditCardPaymentId == creditCardPaymentId);
        }

        public async Task ProcessPayment(int reservationId, ReservationCreditCardPayment payment)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var reservation = (await _appDbContext.Reservations.FindAsync(reservationId))!;
                    reservation.ReservationState = ReservationState.Approved;
                    reservation.PaymentDate = DateTime.Now;
                    await _appDbContext.SaveChangesAsync();
                    await _appDbContext.ReservationCreditCardPayments.AddAsync(payment);
                    await _appDbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw new BadRequestException();
                }
            }
        }
    }
}