using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoangLongDetalClinic.Web.Startup))]
namespace HoangLongDetalClinic.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
