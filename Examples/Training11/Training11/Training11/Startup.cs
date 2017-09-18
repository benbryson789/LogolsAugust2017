using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Training11.Startup))]
namespace Training11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
