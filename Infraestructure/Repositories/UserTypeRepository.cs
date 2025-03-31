namespace Places.Infrastructure.Repositories;

public class UserTypeRepository : Repository<UserType>, IUserTypeRepository
{
    public UserTypeRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}