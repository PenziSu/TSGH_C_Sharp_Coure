using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod01_03.Startup))]
namespace Mod01_03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
