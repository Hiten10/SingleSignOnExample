using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingleSignOnExample.Startup))]
namespace SingleSignOnExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
