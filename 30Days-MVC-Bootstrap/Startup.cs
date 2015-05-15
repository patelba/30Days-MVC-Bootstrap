using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_30Days_MVC_Bootstrap.Startup))]
namespace _30Days_MVC_Bootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
