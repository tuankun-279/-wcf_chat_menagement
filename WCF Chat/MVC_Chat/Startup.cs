using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Chat.Startup))]
namespace MVC_Chat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
