using net_advanced_course.DAL.Settings;

namespace net_advanced_course.DAL
{
    public static class LiteDbServiceExtention
    {
        public static void AddLiteDb(this IServiceCollection services)
        {
            services.AddTransient<LiteDbContextProvider>();
            services.ConfigureOptions<LiteDbSettings>();
        }
    }
}
