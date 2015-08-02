using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoC.Web.Startup))]
namespace CoC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
