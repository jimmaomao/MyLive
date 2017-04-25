using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyLive.Startup))]
namespace MyLive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
