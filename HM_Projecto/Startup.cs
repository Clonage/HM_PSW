using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HM_Projecto.Startup))]
namespace HM_Projecto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
