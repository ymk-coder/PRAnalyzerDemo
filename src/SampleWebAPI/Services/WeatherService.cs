
using SampleWebAPI.Models;
public class WeatherService : IWeatherService
{
    public Task<IEnumerable<WeatherForecast>> GetForecastAsync()
    {
        return Task.FromResult<IEnumerable<WeatherForecast>>(new[]
        {
            new WeatherForecast { TemperatureC = 25, Summary = "Warm" }
        });
    }
}
