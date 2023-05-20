using Microsoft.Extensions.Configuration;

namespace MarsForever.Services
{
    public class NasaPhotoController
    {
        private static readonly IConfiguration _configuration = new ConfigurationManager();
        private static readonly HttpClient _httpClient = new() { };
        private static readonly string apiKey = _configuration.GetValue<string>("apiKey");
        private static readonly Uri baseUrl = new Uri($"https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=801&api_key={apiKey}");
        public static async Task GetCursoityRoverPhotos()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(baseUrl);
        }
    }
}
