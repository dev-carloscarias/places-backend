
namespace Places.Infrastructure.Repositories
{
    public class ReservationRespository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRespository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}