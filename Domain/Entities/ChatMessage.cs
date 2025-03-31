using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class ChatMessage : EntityBase
{
    public int ChatConversationId { get; set; }
    [JsonIgnore]
    public ChatConversation? Conversation { get; set; }

    public int SenderUserId { get; set; }
    public User? Sender { get; set; }

    public string Content { get; set; } = string.Empty;
    public DateTimeOffset SentAt { get; set; } = DateTimeOffset.Now;

    public bool IsRead { get; set; } = false;

    public ICollection<UserChatMessage> UserChatMessages { get; set; } = new List<UserChatMessage>();
}
