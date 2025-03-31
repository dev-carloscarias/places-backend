using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Interfaces.Repositories;
public interface IChatMessageRepository
{
    Task<ChatMessage> CreateAsync(ChatMessage message);
    Task<List<ChatMessage>> GetMessagesByConversationIdAsync(int conversationId);
    Task<int> GetUnreadMessagesCount(int conversationId, int userId);
    Task<int> GetUnreadChatsCount(int userId);
    Task MarkMessagesAsRead(int conversationId, int userId);
    Task<List<ChatMessage>> GetUnreadMessagesByConversationAndUser(int conversationId, int userId);

}
