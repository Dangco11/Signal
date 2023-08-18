namespace SignalRDemo.HubSignal
{
    public interface IMessageHubClient
    {
        Task SendOffersToUser(List<string> message);

        Task SendOffersToGroup(List<string> message,string receiver);

        Task SendOffersToCalls(List<string> message);
        Task AddToGroup(string groupName);
    }
}
