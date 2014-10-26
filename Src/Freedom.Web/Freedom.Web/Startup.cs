using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Freedom.Web.Startup))]
namespace Freedom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
