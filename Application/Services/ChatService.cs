using Places.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class ChatService : IChatService
{
    private readonly IChatConversationRepository _conversationRepo;
    private readonly IChatMessageRepository _messageRepo;
    private readonly IUserChatMessageRepository _userChatMessageRepo;

    public ChatService(IChatConversationRepository conversationRepo, IChatMessageRepository messageRepo, IUserChatMessageRepository userChatMessageRepo)
    {
        _conversationRepo = conversationRepo;
        _messageRepo = messageRepo;
        _userChatMessageRepo = userChatMessageRepo;
    }

    public async Task<ChatConversation> CreateConversationAsync(int userOneId, int userTwoId)
    {
        var existingConversation = await _conversationRepo.GetByUserIdsAsync(userOneId, userTwoId);

        if (existingConversation != null)
        {
            return existingConversation;
        }

        var conversation = new ChatConversation
        {
            UserOneId = userOneId,
            UserTwoId = userTwoId
        };

        return await _conversationRepo.CreateAsync(conversation);
    }

    public async Task<ChatConversation> GetConversationsByIdAsync(int convId)
    {
        return await _conversationRepo.GetConversationsByIdAsync(convId);
    }

    public async Task<List<ChatConversation>> GetConversationsByUserIdAsync(int userId)
    {
        return await _conversationRepo.GetConversationsByUserIdAsync(userId);
    }

    public async Task<List<UserChatMessage>> GetMessagesByConversationIdAsync(int conversationId, int userId)
    {
        return await _userChatMessageRepo.GetUserChatMessagesAsync(userId, conversationId);
    }

    public async Task<int> GetCountMessagesByConversationIdAsync(int conversationId, int userId)
    {
        return await _userChatMessageRepo.GetCountUserChatMessagesAsync(userId, conversationId);
    }

    public async Task<ChatMessage> SendMessageAsync(int conversationId, int senderUserId, string content, DateTime sentAt )
    {
        var conversation = await _conversationRepo.GetByIdAsync(conversationId);
        if (conversation == null)
            throw new Exception("Conversación no encontrada.");

        // Crear mensaje principal
        var message = new ChatMessage
        {
            ChatConversationId = conversationId,
            SenderUserId = senderUserId,
            Content = content,
            SentAt = sentAt
        };

        var savedMessage = await _messageRepo.CreateAsync(message);

        // Crear copias para cada usuario
        var userMessages = new List<UserChatMessage>
        {
            new UserChatMessage
            {
                UserId = conversation.UserOneId,
                ChatMessageId = savedMessage.Id,
                IsRead = false
            },
            new UserChatMessage
            {
                UserId = conversation.UserTwoId,
                ChatMessageId = savedMessage.Id,
                IsRead = false
            }
        };

        await _userChatMessageRepo.CreateUserChatMessagesAsync(userMessages);

        return savedMessage;
    }

    public async Task<int> GetUnreadMessagesCount(int conversationId, int userId)
    {
        return await _messageRepo.GetUnreadMessagesCount(conversationId, userId);
    }

    public async Task<int> GetUnreadChatsCount(int userId)
    {
        return await _messageRepo.GetUnreadChatsCount(userId);
    }
    public async Task MarkMessagesAsRead(int conversationId, int userId)
    {
        var messages = await _messageRepo.GetUnreadMessagesByConversationAndUser(conversationId, userId);

        if (messages.Any())
        {
            foreach (var message in messages)
            {
                var receiverUserChatMessage = await _userChatMessageRepo.GetUserChatMessageAsync(userId, message.Id);

                var senderUserChatMessage = await _userChatMessageRepo.GetUserChatMessageAsync(message.SenderUserId, message.Id);

                if (receiverUserChatMessage != null && receiverUserChatMessage.UserId == userId)
                {
                    receiverUserChatMessage.IsRead = true;

                    if (senderUserChatMessage != null)
                    {
                        senderUserChatMessage.IsRead = true; 
                    }
                }
            }

            await _userChatMessageRepo.UpdateUserChatMessagesAsync();
        }
    }



    public async Task<bool> DeleteConversationsForUser(List<int> conversationIds, int userId)
    {
        return await _conversationRepo.MarkConversationsAsDeleted(conversationIds, userId);
    }

}

