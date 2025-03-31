namespace Places.Infrastructure.Repositories;

public class AmenityRepository : Repository<Amenity>, IAmenityRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public AmenityRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Amenity> GetByIdDataFilesAsync(int id)
    {
        return await _appDbContext.Amenities
         .Include(c => c.Files)
         .FirstOrDefaultAsync(c => c.Id == id && c.IsActive);
    }
}