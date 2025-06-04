using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Places.Domain.Entities;
using Places.Application.Interfaces;
using Places.Application.Services;
using Twilio.TwiML.Messaging;
using Twilio.TwiML.Voice;

namespace Places.Api.Controllers;
[Route("api/v1/[controller]")]
[ApiController]
public class ChatController : ControllerBase
{
    private readonly IChatService _chatService;
    private readonly IMapper _mapper;
    private readonly IHubContext<ChatHub> _hubContext;

    public ChatController(IChatService chatService, IMapper mapper, IHubContext<ChatHub> hubContext)
    {
        _chatService = chatService;
        _mapper = mapper;
        _hubContext = hubContext;
    }

    [HttpPost("CreateConversation")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ChatMessageDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> CreateConversation([FromBody] ChatConversationDto dto)
    {
        var conversation = await _chatService.CreateConversationAsync(dto.UserOneId, dto.UserTwoId);
        return Ok(_mapper.Map<ChatConversationDto>(conversation));
    }

    [HttpGet("UserConversations/{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChatMessageDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetUserConversations(int userId)
    {
        try
        {
            var conversations = await _chatService.GetConversationsByUserIdAsync(userId);
            var convsDto = _mapper.Map<List<ChatConversationDto>>(conversations);
            foreach (var conv in convsDto)
            {
                conv.MessageCount = await _chatService.GetCountMessagesByConversationIdAsync(conv.Id, userId); 
            }
            return Ok(convsDto);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return Ok("");
    }

    [HttpGet("Messages/{conversationId}/{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChatMessageDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetMessages(int conversationId,int userId)
    {
        var messages = await _chatService.GetMessagesByConversationIdAsync(conversationId, userId);
        var messagesDto = messages.Select(m => new ChatMessageDto
        {
            Id = m.ChatMessage.Id,
            ChatConversationId = m.ChatMessage.ChatConversationId,
            SenderUserId = m.ChatMessage.SenderUserId,
            Content = m.ChatMessage.Content,
            SentAt = m.ChatMessage.SentAt,
            UserId = m.UserId,
            IsRead = m.IsRead
        }).ToList();

        return Ok(messagesDto);
    }

    [HttpPost("SendMessage")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ChatMessageDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> SendMessage([FromBody] CreateMessageDto dto)
    {
        var senderUserId = dto.SenderUserId;
        DateTime messageSentAt;
        if (!DateTime.TryParse(dto.SentAt, out messageSentAt))
        {
            // Si no se puede parsear, usar DateTime.UtcNow como respaldo
            messageSentAt = DateTime.UtcNow;
        }
        var message = await _chatService.SendMessageAsync(dto.ChatConversationId, senderUserId, dto.Content, messageSentAt);

        var messageDto = _mapper.Map<ChatMessageDto>(message);

        await _hubContext.Clients.Group(dto.ChatConversationId.ToString())
            .SendAsync("ReceiveMessage", messageDto);

        return Ok(messageDto);
    }

    [HttpGet("UnreadMessages/{conversationId}/{userId}")]
    public async Task<IActionResult> GetUnreadMessagesCount(int conversationId, int userId)
    {
        var count = await _chatService.GetUnreadMessagesCount(conversationId, userId);
        return Ok(new { unreadMessages = count });
    }


    [HttpGet("UnreadChats/{userId}")]
    public async Task<IActionResult> GetUnreadChatsCount(int userId)
    {
        var count = await _chatService.GetUnreadChatsCount(userId);
        return Ok(new { unreadChats = count });
    }

    [HttpPost("MarkAsRead/{conversationId}/{userId}")]
    public async Task<IActionResult> MarkMessagesAsRead(int conversationId, int userId)
    {
        await _chatService.MarkMessagesAsRead(conversationId, userId);
        return Ok(new { message = "Mensajes marcados como leídos" });
    }

    [HttpDelete("delete-multiple")]
    public async Task<IActionResult> DeleteConversations([FromBody] DeleteConversationsRequest request)
    {
        if (request.ConversationIds == null || request.ConversationIds.Count == 0)
        {
            return BadRequest("No se proporcionaron conversaciones para eliminar.");
        }

        var result = await _chatService.DeleteConversationsForUser(request.ConversationIds, request.userId);

        if (!result)
        {
            return StatusCode(500, "Error eliminando las conversaciones.");
        }

        return Ok(new { message = "Conversaciones eliminadas exitosamente." });
    }

}
