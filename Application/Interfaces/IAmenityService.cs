namespace Places.Application.Interfaces;

public interface IAmenityService : IService<Amenity>
{
    Task<IEnumerable<Amenity>> GetAllActive();
}