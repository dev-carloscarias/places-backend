using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Interfaces.Repositories;
public interface IUserChatMessageRepository
{
    Task CreateUserChatMessagesAsync(List<UserChatMessage> userMessages);
    Task<List<UserChatMessage>> GetUserChatMessagesAsync(int userId, int conversationId);
    Task<int> GetCountUserChatMessagesAsync(int userId, int conversationId);
    Task DeleteUserChatMessagesAsync(int userId, int conversationId);
    Task<UserChatMessage?> GetUserChatMessageAsync(int userId, int messageId);
    Task UpdateUserChatMessagesAsync();
}
