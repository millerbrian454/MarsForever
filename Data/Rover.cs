using Newtonsoft.Json;

namespace MarsForever.Data
{
    public class Rover
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("landing_date")]
        public DateTime landingDate { get; set; }
        [JsonProperty("launch_date")]
        public DateTime launchDate { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
    }
}
