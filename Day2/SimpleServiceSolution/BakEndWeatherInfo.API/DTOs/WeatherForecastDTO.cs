namespace BakEndWeatherInfo.API.DTOs
{

    // Data Tranfer Object // Serialization and deserization
    public class WeatherForecastDTO
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
