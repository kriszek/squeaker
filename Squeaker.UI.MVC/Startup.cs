using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Squeaker.DataAccess;
using Squeaker.Model;
using Squeaker.UI.MVC.Models;

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
