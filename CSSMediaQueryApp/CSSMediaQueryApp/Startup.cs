using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSSMediaQueryApp.Startup))]
namespace CSSMediaQueryApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
