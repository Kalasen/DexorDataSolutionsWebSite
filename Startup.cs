using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DexorDataSolutionsWebSite.Startup))]
namespace DexorDataSolutionsWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
