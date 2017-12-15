using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IS403Project2.Startup))]
namespace IS403Project2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
