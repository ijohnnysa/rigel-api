namespace Rigel
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            app.MapGet("/", () => "Olá, mundo!");
        }
    }
}
