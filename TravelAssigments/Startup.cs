using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelAssigments.Startup))]
namespace TravelAssigments
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
