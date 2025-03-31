namespace Places.Infrastructure.Repositories;

public class AmenityBySiteRepository : Repository<AmenityBySite>, IAmenityBySiteRepository
{
    public AmenityBySiteRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}