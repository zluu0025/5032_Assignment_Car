using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5032_Assignment_Car.Startup))]
namespace _5032_Assignment_Car
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
