using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class NotificationsService : INotificationsService
{
    private readonly INotificationsRepository _notificationsRepository;

    public NotificationsService(INotificationsRepository notificationsRepository)
    {
        _notificationsRepository = notificationsRepository;
    }

    public async Task<IEnumerable<Notification>> GetNotificationsbyUserId(int userId)
    {
        return await _notificationsRepository.GetNotificationsbyUserId(userId);
    }
    public async Task<Notification> GetNotificationsbyId(int Id)
    {
        return await _notificationsRepository.GetByIdAsync(Id);
    }

    public async Task<Notification> CreateNotification(Notification notification)
    {
        return await _notificationsRepository.AddAsync(notification);
    }

    public async Task UpdateNotification(Notification notification)
    {
       await _notificationsRepository.UpdateAsync(notification);
    }
}
