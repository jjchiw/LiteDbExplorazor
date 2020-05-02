
using LiteDbExplorazor.LiteDb;
using Microsoft.Extensions.Configuration;
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
      // services.Configure<LiteDbOptions>(Configuration.GetSection("LiteDbOptions"));
      services.AddSingleton<ILiteDbContext, LiteDbContext>();
    }

    public void Configure(DesktopApplicationBuilder app)
    {
      app.AddComponent<App>("app");
    }
  }
}
