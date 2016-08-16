using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AspNetWebApiSignalRDemo.WebApi.Startup))]

namespace AspNetWebApiSignalRDemo.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
