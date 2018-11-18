using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fileupload.Startup))]
namespace fileupload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
