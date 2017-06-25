using Microsoft.Owin;
using Owin;
using PendalePharmacy.Models;

[assembly: OwinStartupAttribute(typeof(PendalePharmacy.Startup))]
namespace PendalePharmacy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
       
    }
}
