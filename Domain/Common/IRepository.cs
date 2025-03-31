namespace Places.Domain.Common;

public interface IRepository<T> where T : EntityBase
{
    public Task<T> AddAsync(T entity);

    public Task<IEnumerable<T>> GetAllAsync();

    public Task<T> GetByIdAsync(int id);

    public Task<T> GetById(int id);
    public Task<IEnumerable<T>> GetPendingToApprove();
    public Task<IEnumerable<Site>> GetSitesbyOwner(int userId);
    public Task<IEnumerable<Site>> GetAllbyManage();
    public Task DeletePermanentlyAsync(int id);
    public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

    public Task<IEnumerable<T>> FindAllAsync();
    public Task<IEnumerable<TResult>> FindAllEficientAsync<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> selector, int pageNumber, int pageSize);
    public Task<IEnumerable<TResult>> FindAllEficientWithoutPageAsync<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> selector);

    public Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);

    public Task<IEnumerable<T>> FindAllNoTrackingAsync(Expression<Func<T, bool>> predicate);

    public Task<T> UpdateAsync(T entity);

    public Task RemoveAsync(T entity);

    public Task<bool> AnyAsync();

    public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

    public Task<QueryResult<T>> GetByQueryRequestAsync(QueryRequest queryRequest);
    public Task<Site> GetAmenitiesbySite(int id);
    public Task<Site> GetAvailabilitiesbySite(int id);
    public Task<Site> GetFeaturesDataForUpdateAsync(int siteId);
    public Task UpdateSiteAsync(Site site);

    Task<IEnumerable<Incident>> GetIncidentsBySiteIdAsync(int siteId);
    Task<Incident?> GetIncidentById(int incidentId);
    Task<Incident> AddIncidentAsync(Incident incident);
    Task<bool> DeleteIncidentAsync(int incidentId);
}