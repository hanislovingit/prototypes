using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChuckPrototype.Startup))]
namespace ChuckPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
