using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternEntity.Context;
using RepositoryPatternEntity.Repositories;
using RepositoryPatternEntity.Repositories.Abstractions;

namespace RepositoryPatternEntity.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            return services;
        }
    }
}
