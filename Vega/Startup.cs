using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vega.Startup))]
namespace Vega
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
