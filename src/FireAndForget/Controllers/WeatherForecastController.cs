using FireForgetTest.FireForget;
using Microsoft.AspNetCore.Mvc;

namespace FireForgetTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IFireForgetHandler _fireForget;

        public WeatherForecastController(IFireForgetHandler fireForget)
        {
            _fireForget = fireForget;
        }


        [HttpGet]
        public IActionResult GetFireForget()
        {
            _fireForget.Execute(async service =>  await service.Process());

            return Ok("fired!!!");
        }
    }
}
