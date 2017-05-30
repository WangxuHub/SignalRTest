using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRGorups
{
    public class GroupsHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}