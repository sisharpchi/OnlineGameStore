using OnlineGameStore.Dal;

namespace OnlineGameStore.Server.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<MainContext>();
        }
    }
}
