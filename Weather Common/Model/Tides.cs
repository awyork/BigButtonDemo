using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Demo.Model
{
    public class Datum
    {
        [JsonProperty("height")]
        public required double Height;

        [JsonProperty("time")]
        public required DateTime TideTime;

        [JsonProperty("type")]
        public required string Type;
    }

    public class Meta
    {
        [JsonProperty("cost")]
        public required int Cost;

        [JsonProperty("dailyQuota")]
        public required int DailyQuota;

        [JsonProperty("datum")]
        public required string Datum;

        [JsonProperty("end")]
        public required string End;

        [JsonProperty("lat")]
        public required double Lat;

        [JsonProperty("lng")]
        public required double Lng;

        [JsonProperty("offset")]
        public required double Offset;

        [JsonProperty("requestCount")]
        public required int RequestCount;

        [JsonProperty("start")]
        public required string Start;

        [JsonProperty("station")]
        public required Station Station;
    }

    public class Tides
    {
        [JsonProperty("data")]
        public required List<Datum> Data;

        [JsonProperty("meta")]
        public required Meta Meta;
    }

    public class Station
    {
        [JsonProperty("distance")]
        public required int Distance;

        [JsonProperty("lat")]
        public required double Lat;

        [JsonProperty("lng")]
        public required double Lng;

        [JsonProperty("name")]
        public required string Name;

        [JsonProperty("source")]
        public required string Source;
    }


}
