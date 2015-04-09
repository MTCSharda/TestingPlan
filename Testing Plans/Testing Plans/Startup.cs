using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testing_Plans.Startup))]
namespace Testing_Plans
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
