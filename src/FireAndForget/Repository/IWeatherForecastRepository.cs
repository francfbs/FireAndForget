using System.Collections.Generic;
using System.Threading.Tasks;

namespace FireForgetTest.Repository
{
    public interface IWeatherForecastRepository
    {
        Task<IEnumerable<WeatherForecast>> GetAll();
    }
}
