using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Interfaces.Repositories;
public interface IChatConversationRepository
{
    Task<ChatConversation> CreateAsync(ChatConversation conversation);
    Task<ChatConversation?> GetByIdAsync(int id);
    Task<ChatConversation?> GetByUserIdsAsync(int userOneId, int userTwoId);
    Task<ChatConversation> GetConversationsByIdAsync(int convId);
    Task<List<ChatConversation>> GetConversationsByUserIdAsync(int userId);
    Task<bool> MarkConversationsAsDeleted(List<int> conversationIds, int userId);
}
