using Places.Domain.Entities;

namespace Places.Domain.Interfaces.Repositories
{
    public interface ISiteRepository : IRepository<Site>
    {
        Task<Site> GetById(int id);
        Task<Site> GetByIdAsync(int id);
        Task<Site> GetByIdLightweight(int id);
        Task<IEnumerable<Site>> GetPendingToApprove();
        Task<IEnumerable<Site>> GetSitesbyOwner(int userId);
        Task<IEnumerable<Site>> GetAllbyManage();
        Task<Site> GetAmenitiesbySite(int id);
        Task<Site> GetAvailabilitiesbySite(int id);
        Task<Site> GetFeaturesDataForUpdateAsync(int siteId);
        Task UpdateSiteAsync(Site site);
        Task<IEnumerable<Incident>> GetIncidentsBySiteIdAsync(int siteId);
        Task<Incident?> GetIncidentById(int incidentId);
        Task<Incident> AddIncidentAsync(Incident incident);
        Task<bool> DeleteIncidentAsync(int incidentId);
        Task<IEnumerable<Site>> FindSiteByTitle(string titlePrefix, int limit = 6);
    }
}
