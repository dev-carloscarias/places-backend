namespace Places.Infrastructure.Repositories;

public class RoleRepository : Repository<Role>, IRoleRepository
{
    public RoleRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}