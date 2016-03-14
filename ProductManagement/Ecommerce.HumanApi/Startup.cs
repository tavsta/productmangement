using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Ecommerce.HumanApi.Startup))]

namespace Ecommerce.HumanApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}