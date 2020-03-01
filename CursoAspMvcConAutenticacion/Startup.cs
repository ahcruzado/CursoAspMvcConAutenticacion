using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursoAspMvcConAutenticacion.Startup))]
namespace CursoAspMvcConAutenticacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
