using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webdemo.Startup))]
namespace webdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
