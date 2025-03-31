using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class CreateMessageDto
{
    public int ChatConversationId { get; set; }
    public int SenderUserId { get; set; }
    public string Content { get; set; } = string.Empty;

    public string SentAt { get; set; } = string.Empty;
}
