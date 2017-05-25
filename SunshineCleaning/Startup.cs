using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunshineCleaning.Startup))]
namespace SunshineCleaning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
