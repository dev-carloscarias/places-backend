using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class NotificationHub : Hub
{
    private static readonly ConcurrentDictionary<string, int> _userConnections = new ConcurrentDictionary<string, int>();

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

    public async Task SendNotification(int userId, string message)
    {
        var connectionId = _userConnections.FirstOrDefault(x => x.Value == userId).Key;
        if (!string.IsNullOrEmpty(connectionId))
        {
            var guatemalaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time");
            var guatemalaTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, guatemalaTimeZone);
            await Clients.Client(connectionId).SendAsync("ReceiveNotification", new
            {
                UserId = userId,
                Message = message,
                Timestamp = guatemalaTime
            });
        }
        else
        {
            Console.WriteLine($"No se encontró ConnectionId para UserId={userId} en NotificationHub");
        }
    }
}
