using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_DoGiaLam.Startup))]
namespace Lab2_DoGiaLam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
