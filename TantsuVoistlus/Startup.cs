using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TantsuVoistlus.Startup))]
namespace TantsuVoistlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
