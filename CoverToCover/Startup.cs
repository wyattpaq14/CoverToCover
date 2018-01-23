using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoverToCover.Startup))]
namespace CoverToCover
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
