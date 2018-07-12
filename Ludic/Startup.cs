using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ludic.Startup))]
namespace Ludic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
