using Microsoft.AspNetCore.Http;
using Places.Application.Dtos.Site;

namespace Places.Application.Interfaces;

public interface ISiteService : IService<Site>
{
    Task SiteApprobation(SiteApprobationDto siteApprobationDto);

    Task<IEnumerable<Site>> GetAllPendingToApprove();
    Task<IEnumerable<Site>> GetSitesByOwner(int userId);

    Task<IEnumerable<Site>> GetAllByCountry(int countryId);

    Task<SiteDto> CreateImages(SiteDto site, IFormCollection formCollection);

    Task<IEnumerable<Site>> GetAllbyFilter(string language,int countryId, int categoryId, int stateId, string nombre, int pageNumber, int pageSize);
    Task<IEnumerable<Site>> GetAllBySearch(string language, string nombre);
    Task<IEnumerable<Site>> GetAllbyManage();
    Task<Site> GetByIdandLanguage(int id, string userLanguage);
    Task DeleteSite(int id);

    Task<Site> ToggleActive(int id);
    Task<Site> UpdateAmenities(int siteId, List<AmenityDto> amenitiesDto);
    Task<Site> UpdateFeatures(int siteId, FeaturesDto featuresDto);
    Task<Site> UpdateSchedule(int siteId, ScheduleDto scheduleDto);
    Task<Site> UpdatePrices(int siteId, PricesDto pricesDto);
    Task<Site> UpdateLocation(int siteId, LocationDto locationDto);
    Task<Site> UpdateSite(Site site);
    Task<Site> GetByIdTracking(int siteId);
    Task<IEnumerable<IncidentDto>> GetIncidentsBySiteIdAsync(int siteId);
    Task<IncidentDto> AddIncidentAsync(IncidentCreateDto dto);
    Task<bool> DeleteIncidentAsync(int incidentId);

}