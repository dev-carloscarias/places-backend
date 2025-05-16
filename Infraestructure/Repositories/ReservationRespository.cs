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
                .AsNoTracking()
                .Include(r => r.Site)
                .ThenInclude(s => s.User)
                .Include(r => r.SpecialPackage)
                .Include(r => r.SelectedTransportOptions)
                .ThenInclude(r => r.SelectedTransportOption)
                .ThenInclude(r => r.TransportOption)
                .Include(r => r.AdditionalCosts)
                .ThenInclude(r => r.AdditionalCost)
                .Include(r => r.CreatedByUser)
                .AsSplitQuery()
                .FirstOrDefaultAsync(c => c.CreditCardPaymentId == creditCardPaymentId);
        }

        public async Task ProcessPayment(int reservationId, ReservationPayment payment)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var reservation = (await _appDbContext.Reservations.FindAsync(reservationId))!;
                    reservation.ReservationState = ReservationState.Approved;
                    reservation.PaymentDate = DateTime.Now;
                    await _appDbContext.SaveChangesAsync();
                    await _appDbContext.ReservationPayments.AddAsync(payment);
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

        public async Task ProcessPendingPayment(int reservationId)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var reservation = (await _appDbContext.Reservations.FindAsync(reservationId))!;
                    reservation.ReservationState = ReservationState.ProcessingPayment;
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
        public async Task ProcessFailedPayment(int reservationId)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var reservation = (await _appDbContext.Reservations.FindAsync(reservationId))!;
                    reservation.ReservationState = ReservationState.Failed;
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

        public async Task<List<Reservation>> FindByPredicate(Expression<Func<Reservation, bool>> predicate)
        {
            return await _appDbContext.Reservations
                .AsNoTracking()
                .Include(c => c.CreatedByUser)
                .Include(r => r.Site)
                .ThenInclude(r => r!.User)
                .Include(c => c.AdditionalCosts)
                .ThenInclude(c => c.AdditionalCost)
                .Include(s => s.SelectedTransportOptions)
                .ThenInclude(vv => vv.SelectedTransportOption)
                .ThenInclude(v => v.TransportOption)
                .Include(p => p.SpecialPackage)
                .Where(predicate)
                .OrderByDescending(c => c.ReservationDate)
                .AsSplitQuery()
                .ToListAsync();
        }
        public async override Task<Reservation> GetById(int id)
        {
            return await _appDbContext.Reservations
                .Include(c => c.AdditionalCosts)
                .Include(s => s.SelectedTransportOptions)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}