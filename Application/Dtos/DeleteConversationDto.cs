using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos;
public class DeleteConversationsRequest
{
    public int userId { get; set; }
    public List<int> ConversationIds { get; set; }
}
