using Newtonsoft.Json;

namespace MarsForever.Data
{
    public class Photo
    {
        [JsonProperty("id")]
        public int photoId { get; set; }
        [JsonProperty("sol")]
        public int sol { get; set; }
        [JsonProperty("img_src")]
        public string imageUrl { get; set; }
        [JsonProperty("earth_date")]
        public DateTime earthDate { get; set; }
        [JsonProperty("camera")]
        public Camera camera { get; set; }
        [JsonProperty("rover")]
        public Rover rover { get; set; }
    }
}
