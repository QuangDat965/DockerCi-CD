using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WetherApi;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "ABC"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStudentService _studentService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("students", Name = "GetAllStudents")]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await _studentService.GetAll());
        }
        [HttpGet("id", Name = "GetAny")]
        public async Task<IActionResult> GetId()
        {
            return Ok(await _studentService.GetAny());
        }
    }
}
