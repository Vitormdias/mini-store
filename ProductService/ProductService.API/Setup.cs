using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductService.Domain.Repositories;
using ProductService.Infra.Context;
using ProductService.Infra.Repositories;

namespace ProductService.API
{
    public static class Setup
    {
        public static void ConfigureDbContext(this IServiceCollection services)
        {
            services.AddScoped<DataContext, DataContext>();
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddCors();
        }

        public static void ConfigureMigrations(this IApplicationBuilder app, DataContext context)
        {
            context.Database.Migrate();
        }
    }
}
