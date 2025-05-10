using Places.Domain.Entities;
using Places.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class NotificationsRepository : Repository<Notification>, INotificationsRepository
{
    private readonly ApplicationDbContext _dbContext;

    public NotificationsRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _dbContext = appDbContext;
    }


    public async Task<IEnumerable<Notification>> GetNotificationsbyUserId(int id)
    {
        var notifications = await _dbContext.Notifications
                .Where(n => n.UserId == id)
                .ToListAsync();
        return notifications;
    }

    public async Task<Notification> GetByIdAsync(int id)
    {
        return (await _dbContext.Set<Notification>()
                                   .AsNoTracking()
                                   .AsQueryable()
                                   .FirstOrDefaultAsync(x => x.Id == id))!;
    }

    public async Task<Notification> AddAsync(Notification notification)
    {
        _dbContext.Notifications.Add(notification);
        await _dbContext.SaveChangesAsync();
        return notification;
    }

    public async Task UpdateAsync(Notification notification)
    {
        _dbContext.Notifications.Update(notification);
        await _dbContext.SaveChangesAsync();
    }

    public async Task MakeReadAll(int userId)
    {
        await _dbContext.Notifications
            .Where(n => n.UserId == userId && !n.IsRead)
            .ExecuteUpdateAsync(setters => setters
            .SetProperty(n => n.IsRead, true));
    }

}
