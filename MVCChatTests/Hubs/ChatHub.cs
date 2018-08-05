using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCChatTests.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMsg(string message, string name)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.Group("NewGroup").addNewMessageToPage(message, name);
        }

        public void Join()
        {
            // Call the addNewMessageToPage method to update clients.
            Groups.Add(Context.ConnectionId, "NewGroup");
        }
    }
}