using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComicHub.Web.Startup))]
namespace ComicHub.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
