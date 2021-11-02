using System.Threading.Tasks;

namespace FireForgetTest.Repository
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repository;
        public WeatherForecastService(IWeatherForecastRepository repository)
        {
            _repository = repository;
        }
        public async Task Process()
        {
            _ = await _repository.GetAll();
        }
    }
}
