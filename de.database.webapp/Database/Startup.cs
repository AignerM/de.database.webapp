using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Database.Startup))]
namespace Database
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
