using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(de.database.webapp.Startup))]
namespace de.database.webapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
