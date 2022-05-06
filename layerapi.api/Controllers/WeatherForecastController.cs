using Microsoft.AspNetCore.Mvc;
using layerapi.business.Services;

namespace layerapi.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
   

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WetherService _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,WetherService serivce)
        {
            _logger = logger;
            _service = serivce;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }
    }
}