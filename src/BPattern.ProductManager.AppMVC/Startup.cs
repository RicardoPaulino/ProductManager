using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BPattern.ProductManager.AppMVC.Startup))]
namespace BPattern.ProductManager.AppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
