using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Concurrent;

namespace Places.Application.Services
{
    public static class ConnectionMapping
    {
        private static readonly ConcurrentDictionary<string, int> _connections = new ConcurrentDictionary<string, int>();

        public static void AddConnection(string connectionId, int userId)
        {
            _connections[connectionId] = userId;
            Console.WriteLine($"Connection added: ConnectionId={connectionId}, UserId={userId}");
        }

        public static void RemoveConnection(string connectionId)
        {
            _connections.TryRemove(connectionId, out _);
            Console.WriteLine($"Connection removed: ConnectionId={connectionId}");
        }

        public static string? GetConnectionId(int userId)
        {
            return _connections.FirstOrDefault(x => x.Value == userId).Key;
        }
    }
}