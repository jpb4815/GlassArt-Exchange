using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPEWebTier.Startup))]
namespace GPEWebTier
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
