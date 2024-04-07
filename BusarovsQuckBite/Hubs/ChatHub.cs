using Microsoft.AspNetCore.SignalR;

namespace BusarovsQuckBite.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message, string orderId)
        {
            if (String.IsNullOrEmpty(message))
            {
                return;
            }
            await Clients.Group($"orderId_{orderId}").SendAsync("ReceiveMessage", message, orderId);
        }
        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
    }
}
