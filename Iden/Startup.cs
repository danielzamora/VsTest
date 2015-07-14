using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Iden.Startup))]
namespace Iden
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
