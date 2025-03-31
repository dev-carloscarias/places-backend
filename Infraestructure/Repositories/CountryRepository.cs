namespace Places.Infrastructure.Repositories;

public class CountryRepository : Repository<Country>, ICountryRepository
{
    public CountryRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}