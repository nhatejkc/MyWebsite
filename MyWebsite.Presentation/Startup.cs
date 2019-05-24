//using Microsoft.Owin;
using Owin;

//[assembly: OwinStartupAttribute(typeof(MyWebsite.Presentation.Startup))]
namespace MyWebsite.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
