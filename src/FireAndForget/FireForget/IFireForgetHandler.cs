using FireForgetTest.Repository;
using System;
using System.Threading.Tasks;

namespace FireForgetTest.FireForget
{
    public interface IFireForgetHandler
    {
        void Execute(Func<IWeatherForecastService, Task> work);
    }
}
