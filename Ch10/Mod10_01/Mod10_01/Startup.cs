using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod10_01.Startup))]
namespace Mod10_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
