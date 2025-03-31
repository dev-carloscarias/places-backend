namespace Places.Application.Services;

public class CountryService : ICountryService
{
    private readonly ICountryRepository _countryRepository;

    private readonly ITranslateRepository _translateRepository;

    private readonly ILocalizationService _localizationService;

    public CountryService(ICountryRepository countryRepository, ILocalizationService localizationService, ITranslateRepository translateRepository)
    {
        _countryRepository = countryRepository;
        _localizationService = localizationService;
        _translateRepository = translateRepository;
    }

    public async Task<Country> Create(Country model)
    {
        return await _countryRepository.AddAsync(model);
    }

    public async Task Delete(int id)
    {
        await _countryRepository.DeletePermanentlyAsync(id);
        return;
    }

    public async Task<Country> Edit(Country model)
    {
        var id = model.Id;
        var original = await _countryRepository.GetById(id);

        if (original is not null)
        {
            return await _countryRepository.UpdateAsync(model);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<Country>> GetAllActive(int? continentId)
    {
        var countries = new List<Country>();

        if (continentId is null)
            countries = (await _countryRepository.FindAllNoTrackingAsync(d => d.IsActive == false || d.IsActive == true)).ToList();
        else
            countries = (await _countryRepository.FindAllNoTrackingAsync(d => d.ContinentId == continentId)).ToList();

        var code = _localizationService.GetLanguage();
        foreach (var country in countries)
        {
            var translation = (await _translateRepository.FindAsync(d => d.CountryId == country.Id && d.LanguageCode == code)).FirstOrDefault();
            if (translation != null) country.Name = translation.Translation;
        }

        return countries;
    }

    public async Task<IEnumerable<Country>> GetAll()
    {
        return await _countryRepository.GetAllAsync();
    }

    public async Task<Country> GetById(int id)
    {
        var current = await _countryRepository.GetById(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _countryRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Country, bool>> predicate)
    {
        return await _countryRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Country>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _countryRepository.GetByQueryRequestAsync(queryRequest);
    }

    public async Task<Country?> GetByIso2CodeAsync(string countryCode)
    {
        return (await _countryRepository.FindAllAsync(d => d.Iso2 == countryCode)).FirstOrDefault();
    }
}