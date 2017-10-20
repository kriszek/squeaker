using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Squeaker.UI.MVC.Startup))]
namespace Squeaker.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
