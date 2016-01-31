using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPEWeb.Startup))]
namespace GPEWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
