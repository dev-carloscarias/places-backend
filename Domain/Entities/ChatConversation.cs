using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Places.Domain.Entities;
public class ChatConversation : EntityBase
{
    public int UserOneId { get; set; }
    public User? UserOne { get; set; }

    public int UserTwoId { get; set; }
    public User? UserTwo { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
    [JsonIgnore]
    public List<ChatMessage> Messages { get; set; } = new();
}