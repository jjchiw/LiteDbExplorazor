using Microsoft.Extensions.DependencyInjection;
using WebWindows.Blazor;

namespace LiteDbExplorazor
{
    public class Startup
    {
        // public Startup(IConfiguration configuration)
        // {
        //   Configuration = configuration;
        // }

        // public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
