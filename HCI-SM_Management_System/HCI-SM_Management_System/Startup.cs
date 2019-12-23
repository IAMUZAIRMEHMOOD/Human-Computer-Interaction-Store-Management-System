using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCI_SM_Management_System.Startup))]
namespace HCI_SM_Management_System
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
