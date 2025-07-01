using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigButtonDemo.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Current
    {
        public required string time { get; set; }
        public required int interval { get; set; }
        public required double temperature_2m { get; set; }
        public required int is_day { get; set; }
        public required double precipitation { get; set; }
        public required int weather_code { get; set; }
    }

    public class CurrentUnits
    {
        public required string time { get; set; }
        public required string interval { get; set; }
        public required string temperature_2m { get; set; }
        public required string is_day { get; set; }
        public required string precipitation { get; set; }
        public required string weather_code { get; set; }
    }

    public class Daily
    {
        public required List<string> time { get; set; }
        public required List<double> temperature_2m_max { get; set; }
        public required List<double> temperature_2m_min { get; set; }
        public required List<string> sunrise { get; set; }
        public required  List<string> sunset { get; set; }
    }

    public class DailyUnits
    {
        public required string time { get; set; }
        public required string temperature_2m_max { get; set; }
        public required string temperature_2m_min { get; set; }
        public required string sunrise { get; set; }
        public required string sunset { get; set; }
    }

    public class Hourly
    {
        public required List<DateTime> time { get; set; }
        public required List<double> temperature_2m { get; set; }
        public required List<int> weather_code { get; set; }
    }

    public class HourlyUnits
    {
        public required string time { get; set; }
        public required string temperature_2m { get; set; }
        public required string weather_code { get; set; }
    }

    public class Minutely15
    {
        public required List<string> time { get; set; }
        public required List<double> precipitation { get; set; }
    }

    public class Minutely15Units
    {
        public required string time { get; set; }
        public required string precipitation { get; set; }
    }

    public class Weather
    {
        public required double latitude { get; set; }
        public required double longitude { get; set; }
        public required double generationtime_ms { get; set; }
        public required int utc_offset_seconds { get; set; }
        public required string timezone { get; set; }
        public required string timezone_abbreviation { get; set; }
        public required double elevation { get; set; }
        public required CurrentUnits current_units { get; set; }
        public required Current current { get; set; }
        public required Minutely15Units minutely_15_units { get; set; }
        public required  Minutely15 minutely_15 { get; set; }
        public required HourlyUnits hourly_units { get; set; }
        public required Hourly hourly { get; set; }
        public required DailyUnits daily_units { get; set; }
        public required Daily daily { get; set; }
    }


}
