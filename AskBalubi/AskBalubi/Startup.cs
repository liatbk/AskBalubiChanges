using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AskBalubi.Startup))]
namespace AskBalubi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
