using CartingService.BLL.Services.Carts;
using CartingService.DAL;
using CartingService.DAL.Repositories.Carts;
using CartingService.DAL.Settings;

namespace CartingService.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<ICartService, CartService>();

        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<ICartRepository, CartRepository>();

        return services;
    }

    public static void AddLiteDb(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<LiteDbContextProvider>();
        builder.Services.Configure<LiteDbSettings>(builder.Configuration.GetSection("LiteDbSettings"));
    }
}
