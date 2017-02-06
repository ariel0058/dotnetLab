using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HtmlHelper_annotationLab.Startup))]
namespace HtmlHelper_annotationLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
