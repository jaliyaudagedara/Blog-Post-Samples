using Microsoft.AspNet.SignalR;

namespace AspNetWebApiSignalRDemo.WebApi.Hubs
{
    public class NotificationHub : Hub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();

        public void Hello()
        {
            Clients.All.hello();
        }

        public static void SayHello()
        {
            hubContext.Clients.All.hello();
        }
    }
}