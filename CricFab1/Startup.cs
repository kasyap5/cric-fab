using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CricFab1.Startup))]
namespace CricFab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
