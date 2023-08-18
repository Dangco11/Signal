using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRDemo.HubSignal;
using System.Text.RegularExpressions;

namespace SignalRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOfferController : ControllerBase
    {
        //private IHubContext<MessageHub,IMessageHubClient> messageHub;
        //public ProductOfferController(IHubContext<MessageHub, IMessageHubClient> _messageHub)
        //{
        //    messageHub = _messageHub;
        //}

        //[HttpGet]
        //[Route("productoffers")]
        //public string Get(string nameUser, string content)
        //{
        //    List<string> offers = new List<string>();
        //    offers.Add($"{nameUser} được khuyến mại {content}");
        //    offers.Add("20% Off on IPhone 12");
        //    messageHub.Clients.All.SendOffersToUser(offers);
        //    return "Offers sent successfully to all users!";
        //}

        //[HttpGet]
        //[Route("productoffersGroup")]
        //public async Task<string> GetGroup(string GroupName,string nameUser,string UserId, string content)
        //{
        //    List<string> offers = new List<string>();
        //    offers.Add($"{nameUser} được khuyến mại {content}");
        //    offers.Add("20% Off on IPhone 12");
        //    await messageHub.Groups.AddToGroupAsync(UserId, GroupName);
        //    await messageHub.Clients.Group(GroupName).SendOffersToGroup(offers, GroupName);
        //    return "Offers sent successfully to all users!";
        //}

        //[HttpGet]
        //[Route("productoffersCalls")]
        //public string GetCall(string render,string nameUser, string content)
        //{
        //    List<string> offers = new List<string>();
        //    offers.Add($"{nameUser} được khuyến mại {content}");
        //    offers.Add("20% Off on IPhone 12");
        //    messageHub.Clients.Client(render).SendOffersToCalls(offers);
        //    return "Offers sent successfully to all users!";
        //}
    }
}
