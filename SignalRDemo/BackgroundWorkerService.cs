using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Contracts;
using SignalRDemo.HubSignal;
using System.Collections;
using System.Threading;

public class BackgroundWorkerService : BackgroundService
{
    readonly IHubContext<MessageHub> _messageHub;
    readonly ILogger<BackgroundWorkerService> _logger;
    public BackgroundWorkerService(ILogger<BackgroundWorkerService> logger, IHubContext<MessageHub> messageHub)
    {
        _logger = logger;
        _messageHub = messageHub;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(10000);

            List<Hashtable> hashtable = new();
            foreach (var item in Group.GroupName)
            {
                var hashtableChild = new Hashtable
                {
                    { "BienSo", item },
                    { "Message", $"ID_{Guid.NewGuid()} --  {DateTime.UtcNow} ++ {item}" }
                };
                hashtable.Add(hashtableChild);
                await _messageHub.Clients.Group(item.Item1).SendAsync("OnMessageReceived", hashtableChild, item.Item2);
            }
        }
    }
}