namespace EmployeeManagementAPI.DTOs
{
    public class WeatherForecast
    {
        // Use DateTime for broader compatibility with Swagger/OpenAPI generation
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
