using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EgtMerkez.Startup))]
namespace EgtMerkez
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
