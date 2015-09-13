using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unitdesign_web.Startup))]
namespace unitdesign_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
