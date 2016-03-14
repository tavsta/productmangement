using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Ecommerce.ProductApi.Startup))]

namespace Ecommerce.ProductApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}