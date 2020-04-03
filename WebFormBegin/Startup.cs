using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormBegin.Startup))]
namespace WebFormBegin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
