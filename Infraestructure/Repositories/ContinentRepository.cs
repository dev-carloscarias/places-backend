namespace Places.Infrastructure.Repositories;

public class ContinentRepository : Repository<Continent>, IContinentRepository
{
    public ContinentRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}