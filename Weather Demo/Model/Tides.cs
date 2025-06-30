using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Demo.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Datum
    {
        public double height { get; set; }
        public DateTime time { get; set; }
        public string type { get; set; }
    }

    public class Meta
    {
        public int cost { get; set; }
        public int dailyQuota { get; set; }
        public string datum { get; set; }
        public string end { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public double offset { get; set; }
        public int requestCount { get; set; }
        public string start { get; set; }
        public Station station { get; set; }
    }

    public class Tides
    {
        public List<Datum> data { get; set; }
        public Meta meta { get; set; }
    }

    public class Station
    {
        public int distance { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string name { get; set; }
        public string source { get; set; }
    }


}
