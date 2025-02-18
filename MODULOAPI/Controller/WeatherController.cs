using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MODULOAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        // GET api/weather
        [HttpGet]
        public IActionResult GetWeather()
        {
            var forecast = new List<string>
            {
                "Sunny",
                "Cloudy",
                "Rainy",
                "Windy"
            };

            return Ok(forecast);
        }
    }
}
