using Asp.Versioning;
using EmployeeManagementAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiVersion("1.0")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new
            {
                Message = "Result from WeatherForecast 1.0 Controller",
                Forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
            });
        }

        // GET api/v1/WeatherForecast/cities
        [HttpGet("cities")]
        public ActionResult GetCities()
        {
            var cities = new[] { "Hyderabad", "Bengaluru", "Chennai", "Mumbai", "Delhi" };
            return Ok(new
            {
                Message = "Cities available in v1",
                Cities = cities
            });
        }
    }
}
