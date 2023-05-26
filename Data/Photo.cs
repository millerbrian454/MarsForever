using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MarsForever.Data
{
    public class Photo
    {
        [JsonPropertyName("id")]
        public int photoId { get; set; }
        [JsonPropertyName("sol")]
        public int sol { get; set; }
        [JsonPropertyName("img_src")]
        public string imageUrl { get; set; }
        [JsonPropertyName("earth_date")]
        public string earthDate { get; set; }
        [JsonPropertyName("camera")]
        public Camera camera { get; set; }
        [JsonPropertyName("rover")]
        public Rover rover { get; set; }
    }
}
