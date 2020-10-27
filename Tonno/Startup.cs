using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tonno.Startup))]
namespace Tonno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
