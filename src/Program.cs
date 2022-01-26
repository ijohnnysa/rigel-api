using Rigel;

WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);

Startup startup = new Startup(webApplicationBuilder.Configuration);
startup.ConfigureServices(webApplicationBuilder.Services);

WebApplication webApplication = webApplicationBuilder.Build();

startup.Configure(webApplication, webApplication.Environment);
webApplication.Run();
