using Microsoft.Extensions.DependencyInjection;

namespace BlazorComponentRouting
{
    public static class ServicesCollection
    {

        public static void AddComponentRouter(this IServiceCollection services)
        {
            services.AddScoped<CrudComponentRouterService>();
        }
    }
}