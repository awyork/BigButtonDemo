using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Demo.Model
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
