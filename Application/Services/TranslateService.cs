namespace Places.Application.Services;

public class TranslateService : ITranslateService
{
    private readonly ITranslateRepository _translateRepository;

    public TranslateService(ITranslateRepository translateRepository)
    {
        _translateRepository = translateRepository;
    }

    public async Task<Translate> Create(Translate model)
    {
        Translate translate = null!;
        if (model.CategoryId is not null)
            translate = (await _translateRepository.FindAsync(x => x.CategoryId == model.CategoryId && x.LanguageCode == model.LanguageCode))?.FirstOrDefault();
        if (model.SiteId is not null)
            translate = (await _translateRepository.FindAsync(x => x.SiteId == model.SiteId && x.LanguageCode == model.LanguageCode && x.FieldName == model.FieldName))?.FirstOrDefault();

        if (translate is not null)
        {
            translate.Translation = model.Translation;
            return await _translateRepository.UpdateAsync(translate);
        }

        return await _translateRepository.AddAsync(model);
    }

    public async Task Delete(int id)
    {
        var original = await _translateRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _translateRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Translate> Edit(Translate model)
    {
        var id = model.Id;
        var original = await _translateRepository.GetByIdAsync(id);

        if (original is not null)
        {
            return await _translateRepository.UpdateAsync(model);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<Translate>> GetAll()
    {
        return await _translateRepository.GetAllAsync();
    }

    public async Task<Translate> GetById(int id)
    {
        var current = await _translateRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _translateRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Translate, bool>> predicate)
    {
        return await _translateRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Translate>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _translateRepository.GetByQueryRequestAsync(queryRequest);
    }
}