using Rs.Api.ConfigureOptions;

namespace Rs.Api.Registrars;

public class MvcRegistrar: IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
    }
}