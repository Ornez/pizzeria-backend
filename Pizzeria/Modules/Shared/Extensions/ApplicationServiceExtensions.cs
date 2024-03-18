using Microsoft.EntityFrameworkCore;
using Pizzeria.Modules.Basket.Services;
using Pizzeria.Modules.Shared.Data;
using Pizzeria.Modules.Token.Services;
using Pizzeria.Modules.Transport.Services;

namespace Pizzeria.Modules.Shared.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddCors();
        services.AddScoped<ITokenService, TokenService>();
        //Tydzień 2, Wzorzec Singleton 1
        //Wzorzec kreacyjny, zapewnia że istnieje dokładnie jedna instancja danej klasy oraz udostępnia ją globalnie
        services.AddSingleton<IBasketService, BasketService>();
        //Koniec, Tydzień 2, Wzorzec Singleton 1.
        services.AddSingleton<ITransportService, TransportService>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddSwaggerGen();
        services.AddDbContext<DataContext>(opt =>
        {
            opt.UseNpgsql(config.GetConnectionString("DefaultConnection"));
        });
        return services;
    }
}
