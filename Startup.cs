using Microsoft.Owin;
using Owin;
using SB_App.DAL;

[assembly: OwinStartupAttribute(typeof(SB_App.Startup))]
namespace SB_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            using (SprintbizContext dbContext = new SprintbizContext())
            {
                dbContext.Database.Exists();
            }
            ConfigureAuth(app);
        }
    }
}
