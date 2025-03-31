namespace Places.Infrastructure.Repositories;

public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
{
    public CurrencyRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}