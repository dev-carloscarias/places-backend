namespace Places.Application.Services;

public class LabelService : ILabelService
{
    private readonly ILabelRepository _labelRepository;

    public LabelService(ILabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public async Task<Label> Create(Label model)
    {
        return await _labelRepository.AddAsync(model);
    }

    public async Task Delete(int id)
    {
        var original = await _labelRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _labelRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Label> Edit(Label model)
    {
        var id = model.Id;
        var original = await _labelRepository.GetByIdAsync(id);

        if (original is not null)
        {
            return await _labelRepository.UpdateAsync(model);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<Label>> GetAll()
    {
        return await _labelRepository.GetAllAsync();
    }

    public async Task<Label> GetById(int id)
    {
        var current = await _labelRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _labelRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Label, bool>> predicate)
    {
        return await _labelRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Label>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _labelRepository.GetByQueryRequestAsync(queryRequest);
    }
}