using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class ChatConversationRepository : Repository<ChatConversation>, IChatConversationRepository
{
    private readonly ApplicationDbContext _context;
    public ChatConversationRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _context = appDbContext;
    }

    public async Task<ChatConversation> CreateAsync(ChatConversation conversation)
    {
        _context.ChatConversations.Add(conversation);
        await _context.SaveChangesAsync();
        return conversation;
    }

    public async Task<ChatConversation?> GetByIdAsync(int id)
    {
        return await _context.ChatConversations
            .Include(c => c.Messages)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<ChatConversation?> GetByUserIdsAsync(int userOneId, int userTwoId)
    {
        return await _context.ChatConversations
            .FirstOrDefaultAsync(c =>
                (c.UserOneId == userOneId && c.UserTwoId == userTwoId) ||
                (c.UserOneId == userTwoId && c.UserTwoId == userOneId));
    }
    public async Task<ChatConversation> GetConversationsByIdAsync(int convId)
    {
        return await _context.ChatConversations
             .Where(c => c.Id == convId)
             .Include(c => c.Messages)
             .AsNoTracking()
             .SingleOrDefaultAsync();
    }

    public async Task<List<ChatConversation>> GetConversationsByUserIdAsync(int userId)
    {
        return await _context.ChatConversations
         .Where(c => c.UserOneId == userId || c.UserTwoId == userId)
         .Include(c => c.Messages)
         .ToListAsync();

    }

    public async Task<bool> DeleteConversationForUser(int conversationId, int userId)
    {
        var userMessages = await _context.UserChatMessages
            .Where(um => um.ChatMessage.ChatConversationId == conversationId && um.UserId == userId)
            .ToListAsync();

        if (!userMessages.Any()) return false;

        foreach (var message in userMessages)
        {
            message.IsDeleted = true;
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> MarkConversationsAsDeleted(List<int> conversationIds, int userId)
    {
        var userMessages = await _context.UserChatMessages
            .Where(um => conversationIds.Contains(um.ChatMessage.ChatConversationId) && um.UserId == userId)
            .ToListAsync();

        if (!userMessages.Any()) return false;

        foreach (var message in userMessages)
        {
            message.IsDeleted = true;
        }

        await _context.SaveChangesAsync();
        return true;
    }

}
