using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GaleriaArtee.Startup))]
namespace GaleriaArtee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
