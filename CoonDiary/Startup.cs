using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoonDiary.Startup))]
namespace CoonDiary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
