using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Weather_Common.Model;
using Weather_Demo.Model;

namespace Weather_Common
{
    public class GetData
    {
        private const string CODES_URL   = "https://yorknation.com/codes.json";
        private const string TIDES_URL   = "https://yorknation.com/tidedatahome.json";
        private const string WEATHER_URL = "https://yorknation.com/data.json";

        private readonly HttpClient client = new();
        private readonly Dictionary<string, Condition> conditions = [];

        public GetData()
        {
            var codesTask = client.GetStringAsync(CODES_URL);
            codesTask.Wait();

            conditions = JsonConvert.DeserializeObject<Dictionary<string, Condition>>(codesTask.Result) ?? [];
        }

        public string DecodeCondition(string condition, bool isDay = true)
        {
            return isDay ? conditions[condition].Day.Desc : conditions[condition].Night.Desc;
        }

        public Tides? GetTideData()
        {
            var tideTask = client.GetStringAsync(TIDES_URL);
            tideTask.Wait();

            var tideData = JsonConvert.DeserializeObject<Tides>(tideTask.Result);

            return tideData;
        }

        public Weather? GetWeatherData()
        {
            var weatherTask = client.GetStringAsync(WEATHER_URL);
            weatherTask.Wait();

            var weatherData = JsonConvert.DeserializeObject<Weather>(weatherTask.Result);

            return weatherData;
        }
    }
}
