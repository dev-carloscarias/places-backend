namespace Places.Application.Interfaces;

public interface ICountryService : IService<Country>
{
    Task<IEnumerable<Country>> GetAllActive(int? continentId);

    Task<Country?> GetByIso2CodeAsync(string countryCode);

    Task<IEnumerable<Country>> GetCountriesOnSites(int continentId);
}