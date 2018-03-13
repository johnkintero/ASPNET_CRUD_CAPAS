using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Presentacion_Layer.Startup))]
namespace Presentacion_Layer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
