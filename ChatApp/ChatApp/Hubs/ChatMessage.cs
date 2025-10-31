using Microsoft.AspNetCore.SignalR;
using System.Text.RegularExpressions;

namespace ChatApp.Hubs
{
    public class ChatMessage : Hub
    {
        public async Task SendMessage(string userId , string message)
        {
           await Clients.All.SendAsync( "ReceiveMessage", userId, Context.ConnectionId);

        }


        public async Task joinGroup(string gName , string name)
        {

          await Groups.AddToGroupAsync(Context.ConnectionId, gName);
          await  Clients.OthersInGroup(gName).SendAsync("ReceiveMessage" ,name , gName);

        }
    }
}
