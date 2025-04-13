
using Azure.Storage.Blobs.Models;

namespace Places.Infrastructure.Repositories
{
    public class ReservationRespository : Repository<Reservation>, IReservationRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public ReservationRespository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public override async Task<Reservation> GetById(int id)
        {
            return await _appDbContext.Reservations
                .Include(r => r.Site)
                .ThenInclude(s => s.SpecialPackage)
                .FirstOrDefaultAsync(c => c.Id == id && c.IsActive);
        }
    }
}