using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActivitySignUp.Startup))]
namespace ActivitySignUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
