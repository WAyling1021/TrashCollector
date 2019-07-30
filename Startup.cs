using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCollectorProject2.Startup))]
namespace TrashCollectorProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
