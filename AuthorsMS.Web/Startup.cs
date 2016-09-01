using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthorsMS.Web.Startup))]
namespace AuthorsMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
