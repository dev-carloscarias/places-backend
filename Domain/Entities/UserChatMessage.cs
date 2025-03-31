using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class UserChatMessage : EntityBase
{
    public int UserId { get; set; }
    public User? User { get; set; }

    public int ChatMessageId { get; set; }
    public ChatMessage? ChatMessage { get; set; }

    public bool IsRead { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
}

