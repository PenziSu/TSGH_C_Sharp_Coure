using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod14_01.Startup))]
namespace Mod14_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
