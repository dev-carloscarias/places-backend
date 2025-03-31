using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Interfaces;
public interface IChatService 
{
    Task<ChatConversation> CreateConversationAsync(int userOneId, int userTwoId);
    Task<List<ChatConversation>> GetConversationsByUserIdAsync(int userId);
    Task<ChatConversation> GetConversationsByIdAsync(int convId);
    Task<List<UserChatMessage>> GetMessagesByConversationIdAsync(int conversationId, int userId);
    Task<int> GetCountMessagesByConversationIdAsync(int conversationId, int userId);
    Task<ChatMessage> SendMessageAsync(int conversationId, int senderUserId, string content, DateTime sentAt);
    Task<int> GetUnreadMessagesCount(int conversationId, int userId);
    Task<int> GetUnreadChatsCount(int userId);
    Task MarkMessagesAsRead(int conversationId, int userId);
    Task<bool> DeleteConversationsForUser(List<int> conversationIds, int userId);

}

