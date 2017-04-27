using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1460017_DAGK.Startup))]
namespace _1460017_DAGK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
