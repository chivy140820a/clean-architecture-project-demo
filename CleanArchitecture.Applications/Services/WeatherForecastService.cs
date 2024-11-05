using CleanArchitecture.Applications.Interfaces;
using CleanArchitecture.Domains.Entities;
using CleanArchitecture.Domains.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Applications.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IRepositoryBase<WeatherForecast> _repository;
        public WeatherForecastService(IRepositoryBase<WeatherForecast> repository)
        {
            _repository = repository;
        }
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return _repository.GetAll();
        }
    }
}
