using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Logistic.Startup))]
namespace Logistic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
