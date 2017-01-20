using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTLogisticsWebForm.Startup))]
namespace CTLogisticsWebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
