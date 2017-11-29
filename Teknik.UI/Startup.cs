using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teknik.UI.Startup))]
namespace Teknik.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
