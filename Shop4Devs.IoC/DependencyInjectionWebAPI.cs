using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop4Devs.Application.Services;
using Shop4Devs.Domain.Interfaces;
using Shop4Devs.Infrastructure.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace Shop4Devs.IoC
{
    public static class DependencyInjectionWebAPI
    {
        public static IServiceCollection AddInfrastructureWebAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDbConnection>(c =>
            {
                string connectionString = configuration.GetConnectionString("DevDockerConnection");
                return new SqlConnection(connectionString);
            });

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ProductService>();

            return services;
        }
    }
}
