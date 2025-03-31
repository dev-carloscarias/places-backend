using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;

public class UserChatMessageRepository : IUserChatMessageRepository
{
    private readonly ApplicationDbContext _context;

    public UserChatMessageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateUserChatMessagesAsync(List<UserChatMessage> userMessages)
    {
        _context.UserChatMessages.AddRange(userMessages);
        await _context.SaveChangesAsync();
    }

    public async Task<List<UserChatMessage>> GetUserChatMessagesAsync(int userId, int conversationId)
    {
        return await _context.UserChatMessages
            .Where(um => um.UserId == userId && um.ChatMessage.ChatConversationId == conversationId && !um.IsDeleted)
            .Include(um => um.ChatMessage)
            .OrderBy(um => um.ChatMessage.SentAt)
            .ToListAsync();
    }

    public async Task<int> GetCountUserChatMessagesAsync(int userId, int conversationId)
    {
        return await _context.UserChatMessages
                .CountAsync(um => um.ChatMessage.ChatConversationId == conversationId
                                  && um.UserId == userId
                                  && !um.IsDeleted);
    }


    public async Task DeleteUserChatMessagesAsync(int userId, int conversationId)
    {
        var messagesToDelete = await _context.UserChatMessages
            .Where(ucm => ucm.UserId == userId && ucm.ChatMessage.ChatConversationId == conversationId)
            .ToListAsync();

        _context.UserChatMessages.RemoveRange(messagesToDelete);
        await _context.SaveChangesAsync();
    }

    public async Task<UserChatMessage?> GetUserChatMessageAsync(int userId, int messageId)
    {
        return await _context.UserChatMessages
            .FirstOrDefaultAsync(ucm => ucm.UserId == userId && ucm.ChatMessageId == messageId);
    }

    public async Task UpdateUserChatMessagesAsync()
    {
        await _context.SaveChangesAsync();
    }

}
