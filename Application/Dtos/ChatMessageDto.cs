using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class ChatMessageDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ChatConversationId { get; set; }
    public int SenderUserId { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTimeOffset SentAt { get; set; }
    public bool IsRead { get; set; }
}
