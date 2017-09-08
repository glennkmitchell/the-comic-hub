using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheComicHub.Web.Startup))]
namespace TheComicHub.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
