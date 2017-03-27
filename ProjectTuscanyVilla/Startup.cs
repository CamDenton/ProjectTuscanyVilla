using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectTuscanyVilla.Startup))]
namespace ProjectTuscanyVilla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
