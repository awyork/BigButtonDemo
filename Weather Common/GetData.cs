using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Weather_Demo.Model;

namespace Weather_Common
{
    public class GetData
    {
        private readonly HttpClient client = new();
        private readonly Dictionary<string, Condition> conditions = [];

        public GetData()
        {
            var codesTask = client.GetStringAsync("https://yorknation.com/codes.json");
            codesTask.Wait();

            conditions = JsonConvert.DeserializeObject<Dictionary<string, Condition>>(codesTask.Result) ?? [];
        }

        public string DecodeCondition(string condition)
        {
            return conditions[condition].Day.Desc;
        }

        public Tides? GetTideData()
        {
            var tideTask = client.GetStringAsync("https://yorknation.com/tidedata.json");
            tideTask.Wait();

            var tideData = JsonConvert.DeserializeObject<Tides>(tideTask.Result);

            return tideData;
        }

        public Weather? GetWeatherData()
        {
            var weatherTask = client.GetStringAsync("https://yorknation.com/data.json");
            weatherTask.Wait();

            var weatherData = JsonConvert.DeserializeObject<Weather>(weatherTask.Result);

            return weatherData;
        }
    }
}
