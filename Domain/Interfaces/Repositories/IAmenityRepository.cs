namespace Places.Domain.Interfaces.Repositories;

public interface IAmenityRepository : IRepository<Amenity> {
    Task<Amenity> GetByIdDataFilesAsync(int id);
}