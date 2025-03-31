using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class ChatConversationDto
{
    public int Id { get; set; }
    public int UserOneId { get; set; }
    public int UserTwoId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public int MessageCount { get; set; }
}
