using FireForgetTest.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace FireForgetTest.FireForget
{
    public class FireForgetHandler : IFireForgetHandler
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public FireForgetHandler(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }


        public void Execute(Func<IWeatherForecastService, Task> work)
        {
            Task.Run(async () =>
            {
                // Exceptions must be caught
                try
                {
                    using var scope = _serviceScopeFactory.CreateScope();
                    var service = scope.ServiceProvider.GetRequiredService<IWeatherForecastService>();
                    await work(service);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });
        }
    }
}
