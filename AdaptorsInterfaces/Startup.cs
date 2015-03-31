using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdaptorsInterfaces.Startup))]
namespace AdaptorsInterfaces
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
