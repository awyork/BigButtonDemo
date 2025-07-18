using Newtonsoft.Json;

namespace WeatherCommon.Model
{
    public class Condition
    {
        [JsonProperty("day")]
        public required Day Day { get; set; }
        [JsonProperty("night")]
        public required Night Night { get; set; }
    }

    public class Day
    {
        [JsonProperty("desc")]
        public required string Desc { get; set; }
    }

    public class Night
    {
        [JsonProperty("desc")]
        public required string Desc { get; set; }
    }
}
