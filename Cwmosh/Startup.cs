using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cwmosh.Startup))]
namespace Cwmosh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
