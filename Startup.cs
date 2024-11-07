using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DangTaiNguyen_2210900052_project2.Startup))]
namespace DangTaiNguyen_2210900052_project2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
