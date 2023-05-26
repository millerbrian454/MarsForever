using MarsForever.Data;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Text.Json;

namespace MarsForever.Services
{
    public class NasaPhotoController
    {
        private const string baseUrl = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos";
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
            {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
            };

    public NasaPhotoController()
        {
            httpClient = new HttpClient();
        }
        public async Task<PhotoResponse> GetCursoityRoverPhotos()
        {
            try
            {
                string apiKey = "ZHsQusIQhMPOCbpz5wVdhoXXWObSmxBaJQZHZ6qw";
                string url = $"{baseUrl}?sol=801&camera=fhaz&api_key={apiKey}";
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
