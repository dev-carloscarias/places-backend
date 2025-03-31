namespace Places.Application.Services;

public class LanguageService : ILanguageService
{
    private readonly ILanguageRepository _languageRepository;

    private readonly ILocalizationService _localizationService;

    private readonly ITranslateRepository _translateRepository;

    public LanguageService(ILanguageRepository languageRepository, ILocalizationService localizationService, ITranslateRepository translateRepository)
    {
        _languageRepository = languageRepository;
        _localizationService = localizationService;
        _translateRepository = translateRepository;
    }

    public async Task<Language> Create(Language model)
    {
        return await _languageRepository.AddAsync(model);
    }

    public async Task Delete(int id)
    {
        var original = await _languageRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _languageRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Language> Edit(Language model)
    {
        var id = model.Id;
        var original = await _languageRepository.GetByIdAsync(id);

        if (original is not null)
        {
            return await _languageRepository.UpdateAsync(model);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<Language>> GetAll()
    {
        var languages = await _languageRepository.GetAllAsync();

        foreach (var language in languages)
        {
            var translation = language.Translates.FirstOrDefault(d => d.LanguageCode.Trim() == language.LanguageCode);
            if (translation != null) language.Name = translation.Translation;
        }

        return languages;
    }

    public async Task<Language> GetById(int id)
    {
        var current = await _languageRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _languageRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Language, bool>> predicate)
    {
        return await _languageRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Language>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _languageRepository.GetByQueryRequestAsync(queryRequest);
    }
}