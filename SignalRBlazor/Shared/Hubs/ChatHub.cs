using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRBlazor.Client.Custom;
//using Microsoft.AspNetCore.SignalR;

namespace SignalRBlazor.Shared.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task LoginMessage(string userCode)
        {
            UserHandler.ConnectedIds.Add( userCode);
            await Clients.All.SendAsync("UpdateUserList", UserHandler.ConnectedIds);
        }

        public override async Task<Task> OnDisconnectedAsync(Exception exception)
        {
            var a= Context.ConnectionId;
            UserHandler.ConnectedIds.Remove(Context.ConnectionId);
            await Clients.All.SendAsync("UpdateUserList", UserHandler.ConnectedIds);
            return base.OnDisconnectedAsync(exception);
        }
        public override async Task<Task> OnConnectedAsync()
        {
            UserHandler.ConnectedIds.Add(Context.ConnectionId);
            await Clients.All.SendAsync("UpdateUserList", UserHandler.ConnectedIds);
            return base.OnConnectedAsync();
        }
    }
    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();
    }
}
