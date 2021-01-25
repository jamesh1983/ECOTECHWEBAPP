using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECOTECHWEBAPP.Startup))]
namespace ECOTECHWEBAPP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
