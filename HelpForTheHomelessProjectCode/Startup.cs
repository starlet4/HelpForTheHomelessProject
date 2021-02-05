using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelpForTheHomelessProject.Startup))]
namespace HelpForTheHomelessProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
