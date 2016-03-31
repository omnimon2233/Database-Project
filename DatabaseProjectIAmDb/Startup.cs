using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseProjectIAmDb.Startup))]
namespace DatabaseProjectIAmDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
