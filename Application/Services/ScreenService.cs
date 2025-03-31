namespace Places.Application.Services;

public class ScreenService : IScreenService
{
    private readonly IScreenRepository _screenRepository;

    private readonly IResourceService _resourceService;

    private readonly ILabelRepository _labelRepository;

    public ScreenService(IScreenRepository screenRepository, ILabelRepository labelRepository, IResourceService resourceService)
    {
        _screenRepository = screenRepository;
        _labelRepository = labelRepository;
        _resourceService = resourceService;
    }

    public async Task<Screen> Create(Screen model)
    {
        return await _screenRepository.AddAsync(model);
    }

    public async Task Delete(int id)
    {
        var original = await _screenRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _screenRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<Screen> Edit(Screen model)
    {
        var id = model.Id;
        var original = await _screenRepository.GetByIdAsync(id);

        if (original is not null)
        {
            return await _screenRepository.UpdateAsync(model);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<Screen>> GetAll()
    {
        return await _screenRepository.GetAllAsync();
    }

    public async Task<Screen> GetById(int id)
    {
        var current = await _screenRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _screenRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<Screen, bool>> predicate)
    {
        return await _screenRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<Screen>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _screenRepository.GetByQueryRequestAsync(queryRequest);
    }

    public async Task<Screen> GetByCode(string screen_code)
    {
        var screen = (await _screenRepository.FindAsync(d => d.ScreenCode == screen_code)).FirstOrDefault();
        screen.Labels = (await _labelRepository.FindAsync(d => d.ScreenId == screen.Id)).ToList();
        foreach (var label in screen.Labels)
            label.LabelValue = _resourceService.GetValueFromKey($"{label.LabelCode}") ?? label.LabelValue;

        return screen;
    }
}