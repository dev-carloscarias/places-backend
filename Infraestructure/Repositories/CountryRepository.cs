namespace Places.Infrastructure.Repositories;

public class CountryRepository : Repository<Country>, ICountryRepository
{
    private readonly ApplicationDbContext _context;
    public CountryRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _context = appDbContext;
    }

    public async Task<IEnumerable<Country>> GetCountriesOnSites(int continentId)
    {
        try
        {
            var countryIds = await _context.Sites
                .Where(s => s.IsSiteApproved)
                .Select(s => s.CountryId)
                .Distinct()
                .ToListAsync();

            return await _context.Countries
                .Where(c => countryIds.Contains(c.Id) && c.ContinentId == continentId)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
 
    }
}