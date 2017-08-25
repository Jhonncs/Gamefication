using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gamification.Web.Startup))]
namespace Gamification.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
