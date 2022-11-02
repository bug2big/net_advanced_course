using net_advanced_course.BLL.Services.Carts;
using net_advanced_course.DAL.Repositories.Carts;

namespace net_advanced_course.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICartingService, CartingService>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICartRepository, CartRepository>();

            return services;
        }
    }
}
