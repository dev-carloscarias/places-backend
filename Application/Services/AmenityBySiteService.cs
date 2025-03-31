namespace Places.Application.Services;

public class AmenityBySiteService : IAmenityBySiteService
{
    private readonly IAmenityBySiteRepository _amenityBySiteRepository;

    public AmenityBySiteService(IAmenityBySiteRepository amenityBySiteRepository)
    {
        _amenityBySiteRepository = amenityBySiteRepository;
    }

    public async Task<AmenityBySite> Create(AmenityBySite model)
    {
        var amenityBySite = await _amenityBySiteRepository.AddAsync(model);

        return amenityBySite;
    }

    public async Task Delete(int id)
    {
        var original = await _amenityBySiteRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _amenityBySiteRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<AmenityBySite> Edit(AmenityBySite model)
    {
        var id = model.Id;
        var original = await _amenityBySiteRepository.GetByIdAsync(id);

        if (original is not null)
        {
            var amenityBySite = await _amenityBySiteRepository.UpdateAsync(model);

            return amenityBySite;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<AmenityBySite>> GetAllActive()
    {
        var amenityBySites = await _amenityBySiteRepository.FindAllAsync();

        return amenityBySites;
    }

    public async Task<IEnumerable<AmenityBySite>> GetAll()
    {
        return await _amenityBySiteRepository.GetAllAsync();
    }

    public async Task<IEnumerable<AmenityBySite>> GetAllBySite(int siteId)
    {
        var amenityBySites = await _amenityBySiteRepository.FindAllAsync(x => x.SiteId == siteId);

        return amenityBySites;
    }

    public async Task<AmenityBySite> GetById(int id)
    {
        var current = await _amenityBySiteRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _amenityBySiteRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<AmenityBySite, bool>> predicate)
    {
        return await _amenityBySiteRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<AmenityBySite>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _amenityBySiteRepository.GetByQueryRequestAsync(queryRequest);
    }
}