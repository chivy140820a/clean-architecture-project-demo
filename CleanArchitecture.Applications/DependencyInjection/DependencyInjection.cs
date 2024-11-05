using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Applications.Interfaces;
using CleanArchitecture.Applications.Services;

namespace Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            return services;
        }
    }
}
