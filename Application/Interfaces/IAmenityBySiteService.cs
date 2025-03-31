namespace Places.Application.Interfaces;

public interface IAmenityBySiteService : IService<AmenityBySite>
{
    Task<IEnumerable<AmenityBySite>> GetAllBySite(int siteId);
}