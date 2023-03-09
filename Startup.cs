using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2080600534_dotruonghoangnhat.Startup))]
namespace _2080600534_dotruonghoangnhat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
