using Places.Infrastructure.Data;
using System;

namespace Places.Infrastructure.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    private readonly ApplicationDbContext _appDbContext;

    public UserRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<User?> FindByEmailAsync(string email)
    {
        return await _appDbContext.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower() && u.IsActive);
    }

    public async Task<User?> FindUserbyIdAsync(int id)
    {
        return (await _appDbContext.Set<User>()
       .AsNoTracking()
       .Include(nameof(User.Hobbies))
       .FirstOrDefaultAsync(x => x.Id == id && x.IsActive))!;
    }

    public async Task<IEnumerable<User>> FindAmins()
    {
        return await _appDbContext.Set<User>()
        .AsNoTracking()
        .Where(x => x.RoleId == 1 && x.IsActive)
        .ToListAsync();
    }
}