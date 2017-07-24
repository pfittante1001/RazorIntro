using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorIntro.Startup))]
namespace RazorIntro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
