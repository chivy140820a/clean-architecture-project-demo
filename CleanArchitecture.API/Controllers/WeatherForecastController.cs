using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Applications.Interfaces;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var forecasts = _weatherForecastService.GetWeatherForecasts();
            return Ok(forecasts);
        }
    }
}
