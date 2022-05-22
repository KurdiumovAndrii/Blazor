using System;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Data
{
    public class DataBaseService
    {

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1,1).Select(index => new WeatherForecast
            {
                Date = DateTime.Now,
            }).ToArray());
        }
    }
}
