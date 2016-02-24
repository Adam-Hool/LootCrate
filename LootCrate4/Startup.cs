using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LootCrate4.Startup))]
namespace LootCrate4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
