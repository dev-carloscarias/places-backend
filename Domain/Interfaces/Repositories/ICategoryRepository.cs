namespace Places.Domain.Interfaces.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<IEnumerable<Category>> FindAllCategoriesWithDataFilesAsync();
    Task<Category> GetByIdDataFilesAsync(int id); 
}
