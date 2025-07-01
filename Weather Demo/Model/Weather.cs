using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Demo.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Current
    {
        [JsonProperty("time")]
        public required string Time { get; set; }
        [JsonProperty("interval")]
        public required int Interval { get; set; }
        [JsonProperty("temperature_2m")]
        public required double Temperature2m { get; set; }
        [JsonProperty("is_day")]
        public required bool IsDay { get; set; }
        [JsonProperty("precipitation")]
        public required double Precipitation { get; set; }
        [JsonProperty("weather_code")]
        public required int WeatherCode { get; set; }
    }

    public class CurrentUnits
    {
        [JsonProperty("time")]
        public required string Time { get; set; }
        [JsonProperty("interval")]
        public required string Interval { get; set; }
        [JsonProperty("temperature_2m")]
        public required string Temperature2m { get; set; }
        [JsonProperty("is_day")]
        public required string IsDay { get; set; }
        [JsonProperty("precipitation")]
        public required string Precipitation { get; set; }
        [JsonProperty("weather_code")]
        public required string WeatherCode { get; set; }
    }

    public class Daily
    {
        [JsonProperty("time")]
        public required List<string> Time { get; set; }
        [JsonProperty("temperature_2m_max")]
        public required List<double> Temperature2mMax { get; set; }
        [JsonProperty("temperature_2m_min")]
        public required List<double> Temperature2mMin { get; set; }
        [JsonProperty("sunrise")]
        public required List<string> Sunrise { get; set; }
        [JsonProperty("sunset")]
        public required  List<string> Sunset { get; set; }
    }

    public class DailyUnits
    {
        [JsonProperty("time")]
        public required string Time { get; set; }
        [JsonProperty("temperature_2m_max")]
        public required string Temperature2mMax { get; set; }
        [JsonProperty("temperature_2m_min")]
        public required string Temperature2mMin { get; set; }
        [JsonProperty("sunrise")]
        public required string Sunrise { get; set; }
        [JsonProperty("sunset")]
        public required string Sunset { get; set; }
    }

    public class Hourly
    {
        [JsonProperty("time")]
        public required List<DateTime> Time { get; set; }
        [JsonProperty("temperature_2m")]
        public required List<double> Temperature2m { get; set; }
        [JsonProperty("weather_code")]
        public required List<int> WeatherCode { get; set; }
    }

    public class HourlyUnits
    {
        [JsonProperty("time")]
        public required string Time { get; set; }
        [JsonProperty("temperature_2m")]
        public required string Temperature2m { get; set; }
        [JsonProperty("weather_code")]
        public required string WeatherCode { get; set; }
    }

    public class Minutely15
    {
        [JsonProperty("time")]
        public required List<string> Time { get; set; }
        [JsonProperty("precipitation")]
        public required List<double> Precipitation { get; set; }
    }

    public class Minutely15Units
    {
        [JsonProperty("time")]
        public required string Time { get; set; }
        [JsonProperty("precipitation")]
        public required string Precipitation { get; set; }
    }

    public class Weather
    {
        [JsonProperty("latitude")]
        public required double Latitude { get; set; }
        [JsonProperty("longitude")]
        public required double Longitude { get; set; }
        [JsonProperty("generationtime_ms")]
        public required double GenerationtimeMs { get; set; }
        [JsonProperty("utc_offset_seconds")]
        public required int UtcOffsetSeconds { get; set; }
        [JsonProperty("timezone")]
        public required string Timezone { get; set; }
        [JsonProperty("timezone_abbreviation")]
        public required string TimezoneAbbreviation { get; set; }
        [JsonProperty("elevation")]
        public required double Elevation { get; set; }
        [JsonProperty("current_units")]
        public required CurrentUnits CurrentUnits { get; set; }
        [JsonProperty("current")]
        public required Current Current { get; set; }
        [JsonProperty("minutely_15_units")]
        public required Minutely15Units Minutely15Units { get; set; }
        [JsonProperty("minutely_15")]
        public required Minutely15 Minutely15 { get; set; }
        [JsonProperty("hourly_units")]
        public required HourlyUnits HourlyUnits { get; set; }
        [JsonProperty("hourly")]
        public required Hourly Hourly { get; set; }
        [JsonProperty("daily_units")]
        public required DailyUnits DailyUnits { get; set; }
        [JsonProperty("daily")]
        public required Daily Daily { get; set; }
    }


}
