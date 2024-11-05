
using CleanArchitecture.Domains.Interfaces;
using CleanArchitecture.Infrastructures.Data;
using CleanArchitecture.Infrastructures.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructures.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("YourConnectionString"));
            return services;
        }
    }
}
