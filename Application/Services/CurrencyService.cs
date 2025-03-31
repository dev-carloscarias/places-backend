namespace Places.Application.Services;

public class CurrencyService : ICurrencyService
{
    private readonly ICurrencyRepository _currencyRepository;

    private readonly ILocalizationService _localizationService;

    private readonly ITranslateRepository _translateRepository;

    public CurrencyService(ICurrencyRepository currencyRepository, ILocalizationService localizationService, ITranslateRepository translateRepository)
    {
        _currencyRepository = currencyRepository;
        _localizationService = localizationService;
        _translateRepository = translateRepository;
    }

    public async Task<Currency> Create(Currency model)
    {
        return await _currencyRepository.AddAsync(model);
    }

    public async Task Delete(int id)
    {
        var original = await _currencyRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _currencyRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Currency> Edit(Currency model)
    {
        var id = model.Id;
        var original = await _currencyRepository.GetByIdAsync(id);

        if (original is not null)
        {
            return await _currencyRepository.UpdateAsync(model);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<Currency>> GetAll()
    {
        var currencies = await _currencyRepository.FindAllAsync();
        var code = _localizationService.GetLanguage();

        foreach (var currency in currencies)
        {
            var translation = (await _translateRepository.FindAsync(d => d.CurrencyId == currency.Id && d.LanguageCode == code)).FirstOrDefault();
            if (translation != null) currency.Name = translation.Translation;
        }

        return currencies.OrderBy(x => x.Name);
    }

    public async Task<Currency> GetById(int id)
    {
        var current = await _currencyRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _currencyRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Currency, bool>> predicate)
    {
        return await _currencyRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Currency>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _currencyRepository.GetByQueryRequestAsync(queryRequest);
    }
}