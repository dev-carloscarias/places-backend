using Places.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Interfaces;
public interface INotificationsService
{ 
    Task<IEnumerable<Notification>> GetNotificationsbyUserId(int userId);

    Task<Notification> GetNotificationsbyId(int userId);

    Task<Notification> CreateNotification(Notification notification);

    Task UpdateNotification(Notification notification);
}
