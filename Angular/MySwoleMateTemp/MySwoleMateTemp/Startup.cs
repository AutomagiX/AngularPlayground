using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySwoleMateTemp.Startup))]
namespace MySwoleMateTemp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
