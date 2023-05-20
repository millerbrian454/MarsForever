using MarsForever.Data;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace MarsForever.Services
{
    public class NasaPhotoController
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;
       
        public NasaPhotoController(IConfiguration configuration)
        {
            this.configuration = configuration;
            httpClient = new HttpClient();
        }

        public async Task<PhotoResponse> GetCursoityRoverPhotos()
        {
            try
            {
                string apiKey = configuration["apiKey"];
                Uri baseUrl = new Uri(configuration["baseUrl"]);
                string url = $"{baseUrl}?sol=801&api_key={apiKey}";
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                PhotoResponse photosResponse = JsonSerializer.Deserialize<PhotoResponse>(json);

                return photosResponse;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving Mars photos.", ex);
            }
        }
    }
}
