using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(livesearchtask.Startup))]
namespace livesearchtask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
