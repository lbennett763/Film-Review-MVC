using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmReview_MVC_Website.Startup))]
namespace FilmReview_MVC_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
