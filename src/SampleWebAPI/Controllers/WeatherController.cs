
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Services;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    public async Task<IActionResult> GetWeather()
    {
        var result = await _weatherService.GetForecastAsync();
        return Ok(result);
    }
}
