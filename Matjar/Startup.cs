using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Matjar.Startup))]
namespace Matjar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
