using System.Text.Json.Serialization;

namespace MarsForever.Data
{
    public class Camera
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("name")]
        public string shortName { get; set; }
        [JsonPropertyName("rover_id")]
        public int roverId { get; set; }
        [JsonPropertyName("img_src")]
        public string fullName { get; set; }
    }
}
