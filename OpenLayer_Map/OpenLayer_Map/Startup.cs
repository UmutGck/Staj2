using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenLayer_Map.Startup))]
namespace OpenLayer_Map
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
