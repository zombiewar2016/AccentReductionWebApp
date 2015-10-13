using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccentReductionWebApp.Startup))]
namespace AccentReductionWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
