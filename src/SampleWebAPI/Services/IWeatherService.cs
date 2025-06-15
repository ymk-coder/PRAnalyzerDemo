
using SampleWebAPI.Models;
public interface IWeatherService
{
    Task<IEnumerable<WeatherForecast>> GetForecastAsync();
}
