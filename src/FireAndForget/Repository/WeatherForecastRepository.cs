using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FireForgetTest.Repository
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        public Task<IEnumerable<WeatherForecast>> GetAll()
        {
            Thread.Sleep(15000);

            var rng = new Random();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Summary} {item.TemperatureC}°C - {item.TemperatureF}°F");
            }

            return Task.FromResult(result);
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
