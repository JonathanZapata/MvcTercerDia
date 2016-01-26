using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTercerDia.Startup))]
namespace MvcTercerDia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
