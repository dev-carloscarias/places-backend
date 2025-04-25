using Places.Application.Interfaces;

namespace Places.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    private readonly ILocalizationService _localizationService;

    private readonly ITranslateService _translateService;

    private readonly ILanguageService _languageService;

    private readonly ITranslationService _translationService;

    private readonly ITranslateRepository _translateRepository;
    private readonly IDataService _dataService;

    public CategoryService(ICategoryRepository categoryRepository, ILocalizationService localizationService,
        ITranslateService translateService, ILanguageService languageService, ITranslationService translationService,
        ITranslateRepository translateRepository, IDataService dataService)
    {
        _categoryRepository = categoryRepository;
        _localizationService = localizationService;
        _translateService = translateService;
        _languageService = languageService;
        _translationService = translationService;
        _translateRepository = translateRepository;
        _dataService = dataService;
    }

    public async Task<Category> Create(Category model)
    {
        foreach (var file in model.DataFiles)
        {
            var filePath = await _dataService.UploadFile($"Sites/{Guid.NewGuid().ToString()}/{Guid.NewGuid().ToString()}.{file.DataTypeExtension.ToString()}", file.Path);
            file.Path = filePath;
        }
        var category = await _categoryRepository.AddAsync(model);
        var languages = await _languageService.GetAll();
        var currentLanguage = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        // foreach (var language in languages.Select(d => d.LanguageCode))
        // {
        //     var resultTranslate = await _translationService.TranslateTextAsync(new TranslationRequest { SourceLanguage = currentLanguage, TargetLanguage = language, Text = model.Name });
        //     await _translateService.Create(new Translate { CategoryId = category.Id, IsActive = true, LanguageCode = language, Translation = resultTranslate.TranslatedText });
        // }
        return category;
    }

    public async Task Delete(int id)
    {
        var original = await _categoryRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _categoryRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Category> Edit(Category model)
    {
        var id = model.Id;
        var original = await _categoryRepository.GetByIdDataFilesAsync(id);

        if (original is not null)
        {
            original.Name = model.Name;
            if (!model.DataFiles.ElementAt(0).Path.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                original.DataFiles = model.DataFiles;
            }

            foreach (var file in original.DataFiles)
            {
                if (!file.Path.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    var filePath = await _dataService.UploadFile($"Categories/{Guid.NewGuid().ToString()}/{Guid.NewGuid().ToString()}.{file.DataTypeExtension.ToString()}", file.Path);
                    file.Path = filePath;
                }
            }
            var category = await _categoryRepository.UpdateAsync(original);

            return category;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<Category>> GetAllActive()
    {
        var categories = await _categoryRepository.FindAllCategoriesWithDataFilesAsync();

        /*var code = _localizationService.GetLanguage();
        foreach (var category in categories)
        {
            var translation = (await _translateRepository.FindAsync(d => d.CategoryId == category.Id && d.LanguageCode == code)).FirstOrDefault();
            if (translation != null) category.Name = translation.Translation;
        }*/

        return categories;
    }

    public async Task<IEnumerable<Category>> GetAll()
    {
        return await _categoryRepository.GetAllAsync();
    }

    public async Task<Category> GetById(int id)
    {
        var current = await _categoryRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _categoryRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Category, bool>> predicate)
    {
        return await _categoryRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Category>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _categoryRepository.GetByQueryRequestAsync(queryRequest);
    }
}