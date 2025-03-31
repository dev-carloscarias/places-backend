using Places.Domain.Interfaces.Repositories;

namespace Places.Application.Services;

public class AmenityService : IAmenityService
{
    private readonly IAmenityRepository _amenityRepository;

    private readonly ILocalizationService _localizationService;

    private readonly ITranslateService _translateService;

    private readonly ILanguageService _languageService;

    private readonly ITranslationService _translationService;

    private readonly ITranslateRepository _translateRepository;

    private readonly IDataService _dataService;

    public AmenityService(IAmenityRepository amenityRepository, ILocalizationService localizationService,
        ITranslateService translateService, ILanguageService languageService, ITranslationService translationService,
        ITranslateRepository translateRepository, IDataService dataService)
    {
        _amenityRepository = amenityRepository;
        _localizationService = localizationService;
        _translateService = translateService;
        _languageService = languageService;
        _translationService = translationService;
        _translateRepository = translateRepository;
        _dataService = dataService;
    }

    public async Task<Amenity> Create(Amenity model)
    {
        if (model.Files.Count > 0)
        {
            foreach (var file in model.Files)
            {
                file.Path = await _dataService.UploadFile($"{model.Id}/{Guid.NewGuid().ToString()}.png", file.Path);
            }
        }

        var amenity = await _amenityRepository.AddAsync(model);
        var languages = await _languageService.GetAll();
        var currentLanguage = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        foreach (var language in languages.Select(d => d.LanguageCode))
        {
            var resultTranslate = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = language, Text = model.Name });
            await _translateService.Create(new Translate { CategoryId = amenity.Id, IsActive = true, LanguageCode = language, Translation = resultTranslate.TranslatedText });
        }

        return amenity;
    }

    public async Task Delete(int id)
    {
        var original = await _amenityRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _amenityRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Amenity> Edit(Amenity model)
    {
        var id = model.Id;
        var original = await _amenityRepository.GetByIdDataFilesAsync(id);

        if (original is not null)
        {
            original.Name = model.Name;
            original.Files = model.Files;

            foreach (var file in original.Files)
            {
                if (!file.Path.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    var filePath = await _dataService.UploadFile($"Categories/{Guid.NewGuid().ToString()}/{Guid.NewGuid().ToString()}.{file.DataTypeExtension.ToString()}", file.Path);
                    file.Path = filePath;
                }
            }
            var amenity = await _amenityRepository.UpdateAsync(original);

            return amenity;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }


    public async Task<IEnumerable<Amenity>> GetAllActive()
    {
        var amenities = await _amenityRepository.FindAllAsync();
       /* var code = _localizationService.GetLanguage();
        foreach (var amenity in amenities)
        {
            var translation = (await _translateRepository.FindAsync(d => d.CategoryId == amenity.Id && d.LanguageCode == code)).FirstOrDefault();
            if (translation != null) amenity.Name = translation.Translation;
        }*/

        return amenities;
    }

    public async Task<IEnumerable<Amenity>> GetAll()
    {
        return await _amenityRepository.GetAllAsync();
    }

    public async Task<Amenity> GetById(int id)
    {
        var current = await _amenityRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _amenityRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Amenity, bool>> predicate)
    {
        return await _amenityRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Amenity>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _amenityRepository.GetByQueryRequestAsync(queryRequest);
    }
}