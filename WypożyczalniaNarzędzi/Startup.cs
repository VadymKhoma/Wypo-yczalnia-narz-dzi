using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WypożyczalniaNarzędzi.Startup))]
namespace WypożyczalniaNarzędzi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
