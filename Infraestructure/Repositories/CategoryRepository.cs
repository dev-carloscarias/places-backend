using Places.Infrastructure.Data;

namespace Places.Infrastructure.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public CategoryRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IEnumerable<Category>> FindAllCategoriesWithDataFilesAsync()
    {
        return await _appDbContext.Categories
            .Where(c => c.IsActive)
            .Include(c => c.DataFiles)
            .ToListAsync();
    }

    public async Task<Category> GetByIdDataFilesAsync(int id)
    {
        return await _appDbContext.Categories
         .Include(c => c.DataFiles)
         .FirstOrDefaultAsync(c => c.Id == id && c.IsActive);
    }
}
