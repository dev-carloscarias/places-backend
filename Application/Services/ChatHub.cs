using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class ChatHub : Hub
{
    private readonly IChatService _chatService;
    private readonly IHubContext<NotificationHub> _notificationHubContext;
    private readonly INotificationsService _notificationsService;
    private readonly IUserService _userService;
    public ChatHub(IChatService chatService, IHubContext<NotificationHub> notificationHubContext, INotificationsService notificationsService, IUserService userService)
    {
        _chatService = chatService;
        _notificationsService = notificationsService;
        _notificationHubContext = notificationHubContext;
        _userService = userService;
    }

    public async Task RegisterUser(int userId)
    {
        ConnectionMapping.AddConnection(Context.ConnectionId, userId);
        await Task.CompletedTask;
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        ConnectionMapping.RemoveConnection(Context.ConnectionId);
        await base.OnDisconnectedAsync(exception);
    }

    public async Task SendMessage(int conversationId, int senderUserId, string content, string sentAt)
    {
        DateTime messageSentAt;
        if (!DateTime.TryParse(sentAt, out messageSentAt))
        {
            // Si no se puede parsear, usar DateTime.UtcNow como respaldo
            messageSentAt = DateTime.UtcNow;
        }

        var message = await _chatService.SendMessageAsync(conversationId, senderUserId, content, messageSentAt);

        var messageDto = new ChatMessageDto
        {
            Id = message.Id,
            ChatConversationId = message.ChatConversationId,
            SenderUserId = message.SenderUserId,
            Content = message.Content,
            SentAt = message.SentAt
        };

        await Clients.Group($"conversation_{conversationId}")
            .SendAsync("ReceiveMessage", messageDto);

        // Obtener el ID del receptor (el otro usuario en la conversación)
        var conversation = await _chatService.GetConversationsByIdAsync(conversationId);
        if (conversation != null)
        {
            int? receiverUserId = senderUserId == conversation.UserOneId ? conversation.UserTwoId : conversation.UserOneId;
            if (receiverUserId.HasValue)
            {
                var user = await _userService.GetById(senderUserId);
                var receiverNotification = new Notification
                {
                    UserId = receiverUserId.Value,
                    profilePhoto = user.ProfilePicture,
                    Message = "Un mensaje nuevo de " + user.FirstName + user.LastName + " !",
                    Timestamp = messageSentAt
                };
                // Encontrar el ConnectionId del receptor
                var receiverConnectionId = ConnectionMapping.GetConnectionId(receiverUserId.Value);
                if (!string.IsNullOrEmpty(receiverConnectionId))
                {

                    await _notificationHubContext.Clients.Client(receiverConnectionId)
                    .SendAsync("ReceiveNotification", receiverNotification);

                    await Clients.Client(receiverConnectionId)
                       .SendAsync("NewMessageNotification", new
                       {
                           ConversationId = conversationId,
                           SenderUserId = senderUserId,
                           UnreadMessages = 1
                       });

                    await Clients.Client(receiverConnectionId)
                        .SendAsync("ReceiveMessage", new
                        {
                            ConversationId = conversationId,
                            SenderUserId = senderUserId,
                            UnreadMessages = 1
                        });
                }
                await _notificationsService.CreateNotification(receiverNotification);


            }
        }
    }

    public async Task JoinConversation(int conversationId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, $"conversation_{conversationId}");
    }


    public async Task LeaveConversation(int conversationId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"conversation_{conversationId}");
    }

    public async Task MarkMessagesAsRead(int conversationId, int userId)
    {
        try
        {
            await _chatService.MarkMessagesAsRead(conversationId, userId);
            var readNotification = new
            {
                ConversationId = conversationId,
                UserId = userId 
            };

            await Clients.Group($"conversation_{conversationId}")
                .SendAsync("MessagesRead", readNotification);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error en MarkMessagesAsRead: {ex.Message}");
        }
    }

}

