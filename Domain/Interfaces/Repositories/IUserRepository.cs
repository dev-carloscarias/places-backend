namespace Places.Domain.Interfaces.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<User?> FindByEmailAsync(string email);
    Task<User?> FindUserbyIdAsync(int id);

    Task<IEnumerable<User>> FindAmins();
}