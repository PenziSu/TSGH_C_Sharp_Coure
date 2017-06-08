using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod13_01.Startup))]
namespace Mod13_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
