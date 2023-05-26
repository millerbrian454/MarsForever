using MarsForever.Data;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Text.Json;

namespace MarsForever.Services
{
    public class NasaPhotoController
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;
        private readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
            {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
            };

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
                string url = $"{baseUrl}?sol=1000&camera=fhaz&api_key={apiKey}";
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string photosResponse = await response.Content.ReadAsStringAsync();
                var deserializedJsonResponse = JsonSerializer.Deserialize<PhotoResponse>(photosResponse, _serializerOptions);

                return deserializedJsonResponse;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
                throw;
            }
        }
    }
}
