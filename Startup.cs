using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fitariqik.Startup))]
namespace fitariqik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
