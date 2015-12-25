using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoWebApiUdemy.Startup))]
namespace VideoWebApiUdemy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
