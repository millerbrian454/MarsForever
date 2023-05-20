using Newtonsoft.Json;

namespace MarsForever.Data
{
    public class Camera
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string shortName { get; set; }
        [JsonProperty("rover_id")]
        public int roverId { get; set; }
        [JsonProperty("img_src")]
        public string fullName { get; set; }
    }
}
