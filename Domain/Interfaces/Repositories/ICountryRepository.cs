namespace Places.Domain.Interfaces.Repositories;

public interface ICountryRepository : IRepository<Country>
{
    Task<IEnumerable<Country>> GetCountriesOnSites(int continentId);
}