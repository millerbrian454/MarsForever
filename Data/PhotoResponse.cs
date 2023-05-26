using System.Text.Json.Serialization;

namespace MarsForever.Data
{
    public class PhotoResponse
    {
        [JsonPropertyName("photos")]
        public ICollection<Photo> marsRoverPhotos { get; set; }
    }
}
