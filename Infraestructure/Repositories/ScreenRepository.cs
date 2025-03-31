namespace Places.Infrastructure.Repositories;

public class ScreenRepository : Repository<Screen>, IScreenRepository
{
    public ScreenRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}