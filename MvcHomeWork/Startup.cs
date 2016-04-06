using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcHomeWork.Startup))]
namespace MvcHomeWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
