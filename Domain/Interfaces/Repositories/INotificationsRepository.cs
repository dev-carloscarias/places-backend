using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Interfaces.Repositories;
public interface INotificationsRepository : IRepository<Notification>
{
    Task<IEnumerable<Notification>> GetNotificationsbyUserId(int id);
    Task UpdateAsync(Notification notification);
}