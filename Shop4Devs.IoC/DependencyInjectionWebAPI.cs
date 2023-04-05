using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shop4Devs.IoC
{
    public static class DependencyInjectionWebAPI
    {
        public static IServiceCollection AddInfrastructureWebAPI(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
