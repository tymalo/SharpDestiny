using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharpDestiny.Web.Startup))]
namespace SharpDestiny.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
