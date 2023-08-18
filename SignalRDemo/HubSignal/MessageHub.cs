using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Contracts;
using System.Collections;

namespace SignalRDemo.HubSignal
{
    public class MessageHub : Hub
    {
        public async Task SendOffersToUser(string nameUser)
        {
            List<string> offers = new List<string>();
            offers.Add($"{nameUser} được khuyến mại");
            offers.Add("20% Off on IPhone 12");
            await Clients.Client(Context.ConnectionId).SendAsync("SendOffersToUser", offers);
        }

        public async Task SendOffersToGroup(GroupRequest groupRequest)
        {
            Hashtable numberNames = new Hashtable
            {
                { "BienSo", $"{groupRequest.GroupName}" },
                { "Message", $"{groupRequest.GroupName} +++ {groupRequest.UserName} trả giá biển : {groupRequest.AmountMoney} ++ContextID - {Context.ConnectionId}" },
                { "ContextId", $"{Context.ConnectionId}" }
            };

            await Clients.Group(groupRequest.GroupName).SendAsync("SendOffersToGroup", numberNames, Context.ConnectionId);
        }

        public async Task AddToGroup(string groupName)
        {
            if(Group.GroupName != null && !Group.GroupName.Any(p=>p.Equals(groupName)))
            {
                Tuple<string, string> tuple = new Tuple<string, string>(groupName,Context.ConnectionId);

                Group.GroupName?.Add(tuple);
            }
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendOffersToCliens(string message, string connectId)
        {
            await Clients.Client(connectId).SendAsync("SendOffersToCliens", message);
        }
    }
}
