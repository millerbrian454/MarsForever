using System.Text.Json.Serialization;

namespace MarsForever.Data
{
    public class Rover
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("landing_date")]
        public DateTime landingDate { get; set; }
        [JsonPropertyName("launch_date")]
        public DateTime launchDate { get; set; }
        [JsonPropertyName("status")]
        public string status { get; set; }
    }
}
