using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class ChatMessageRepository : Repository<ChatMessage>, IChatMessageRepository
{
    private readonly ApplicationDbContext _context;
    public ChatMessageRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _context = appDbContext;
    }

    public async Task<ChatMessage> CreateAsync(ChatMessage message)
    {
        _context.ChatMessages.Add(message);
        await _context.SaveChangesAsync();
        return message;
    }

    public async Task<List<ChatMessage>> GetMessagesByConversationIdAsync(int conversationId)
    {
        return await _context.ChatMessages
            .Where(m => m.ChatConversationId == conversationId)
            .OrderBy(m => m.SentAt)
            .ToListAsync();
    }

    public async Task<int> GetUnreadMessagesCount(int conversationId, int userId)
    {
        return await _context.UserChatMessages
         .Where(ucm => ucm.ChatMessage.Conversation.Id == conversationId
                       && ucm.UserId == userId
                       && ucm.ChatMessage.SenderUserId != userId
                       && !ucm.IsRead)
         .CountAsync();
    }

    public async Task<int> GetUnreadChatsCount(int userId)
    {
        return await _context.ChatMessages
            .Where(m => m.Conversation.UserOneId == userId || m.Conversation.UserTwoId == userId)
            .Where(m => m.SenderUserId != userId && !m.IsRead)
            .Select(m => m.ChatConversationId)
            .Distinct()
            .CountAsync();
    }

    public async Task MarkMessagesAsRead(int conversationId, int userId)
    {
        var unreadMessages = await _context.ChatMessages
            .Where(m => m.ChatConversationId == conversationId && m.SenderUserId != userId && !m.IsRead)
            .ToListAsync();

        foreach (var message in unreadMessages)
        {
            message.IsRead = true;
        }

        await _context.SaveChangesAsync();
    }

    public async Task<List<ChatMessage>> GetUnreadMessagesByConversationAndUser(int conversationId, int userId)
    {
        return await _context.ChatMessages
          .Where(m => m.ChatConversationId == conversationId
                      && m.SenderUserId != userId
                      && !_context.UserChatMessages
                          .Where(ucm => ucm.UserId == userId && ucm.ChatMessageId == m.Id)
                          .Any(ucm => ucm.IsRead))
          .OrderBy(m => m.SentAt)
          .ToListAsync();
    }

}

