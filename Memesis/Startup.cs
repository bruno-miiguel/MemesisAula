using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Memesis.Startup))]
namespace Memesis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
