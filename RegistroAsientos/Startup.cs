using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegistroAsientos.Startup))]
namespace RegistroAsientos
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
