
namespace Places.Infrastructure.Common;

public class Repository<T> : IRepository<T> where T : EntityBase
{
    private readonly ApplicationDbContext _applicationDbContext;

    public Repository(ApplicationDbContext appDbContext)
    {
        _applicationDbContext = appDbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        entity.CreatedAt = DateTimeOffset.Now;
        entity.IsActive = true;
        _applicationDbContext.Set<T>().Add(entity);
        await _applicationDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _applicationDbContext.Set<T>().Where(x => x.IsActive).Where(predicate).ToListAsync();
    }

    public async Task<IEnumerable<T>> FindAllAsync()
    {
        return await _applicationDbContext.Set<T>().Where(x => x.IsActive).ToListAsync();
    }
    public async Task<IEnumerable<TResult>> FindAllEficientAsync<TResult>(
    Expression<Func<T, bool>> predicate,
    Expression<Func<T, TResult>> selector, int pageNumber,int pageSize)
    {
         return await _applicationDbContext.Set<T>()
        .AsNoTracking()
        .Where(predicate)
        .OrderByDescending(x => x.Id) 
        .Skip((pageNumber - 1) * pageSize)
        .Take(pageSize)
        .Select(selector)
        .ToListAsync();
    }

    public async Task<IEnumerable<TResult>> FindAllEficientWithoutPageAsync<TResult>(
    Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> selector)
    {
        return await _applicationDbContext.Set<T>()
       .AsNoTracking()
       .Where(predicate)
       .OrderBy(x => x.Id)
       .Select(selector)
       .ToListAsync();
    }

    public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
    {
        return await _applicationDbContext.Set<T>().Where(predicate).ToListAsync();
    }

    public async Task<IEnumerable<T>> FindAllNoTrackingAsync(Expression<Func<T, bool>> predicate)
    {
        return await _applicationDbContext.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
    }


    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _applicationDbContext.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return (await _applicationDbContext.Set<T>()
                                   .AsNoTracking()
                                   .AsQueryable()
                                   .FirstOrDefaultAsync(x => x.Id == id && x.IsActive))!;
    }

    public virtual async Task<T> GetById(int id)
    {
        return (await _applicationDbContext.Set<T>()
                                   .AsNoTracking()
                                   .AsQueryable()
                                   .FirstOrDefaultAsync(x => x.Id == id))!;
    }

    public Task<QueryResult<T>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        throw new NotImplementedException();
    }

    public async Task RemoveAsync(T entity)
    {
        entity.UpdatedAt = DateTimeOffset.Now;
        entity.IsActive = false;
        _applicationDbContext.Set<T>().Update(entity!);
        await _applicationDbContext.SaveChangesAsync();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        entity.UpdatedAt = DateTimeOffset.Now;
        _applicationDbContext.Set<T>().Update(entity!);
        await _applicationDbContext.SaveChangesAsync();

        return entity!;
    }

    public async Task<bool> AnyAsync()
    {
        return await _applicationDbContext.Set<T>().AnyAsync(x => x.IsActive);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
    {
        return await _applicationDbContext.Set<T>().Where(x => x.IsActive).AnyAsync(predicate);
    }

    public Task<IEnumerable<T>> GetPendingToApprove()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Site>> GetAllbyManage()
    {
        throw new NotImplementedException();
    }

    public async Task DeletePermanentlyAsync(int id)
    {
        var entity = await _applicationDbContext.Set<T>().FindAsync(id);

        _applicationDbContext.Set<T>().Remove(entity);
        await _applicationDbContext.SaveChangesAsync();
    }

    public Task<IEnumerable<Site>> GetSitesbyOwner(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<Site> GetAmenitiesbySite(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Site> GetAvailabilitiesbySite(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Site> GetFeaturesDataForUpdateAsync(int siteId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateSiteAsync(Site site)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Incident>> GetIncidentsBySiteIdAsync(int siteId)
    {
        throw new NotImplementedException();
    }

    public Task<Incident> AddIncidentAsync(Incident incident)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteIncidentAsync(int incidentId)
    {
        throw new NotImplementedException();
    }

    public Task<Incident?> GetIncidentById(int incidentId)
    {
        throw new NotImplementedException();
    }
}