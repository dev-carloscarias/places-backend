namespace Places.Application.Interfaces;

public interface ICategoryService : IService<Category>
{
    Task<IEnumerable<Category>> GetAllActive();
}