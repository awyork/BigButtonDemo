using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Weather_Demo.Model;

namespace BigButtonDemo
{
    public partial class MainForm : Form
    {
        private readonly HttpClient client = new();
        private readonly Dictionary<string, Condition> WeatherCodes;

        public MainForm()
        {
            InitializeComponent();

            WeatherCodes = GetWeatherCodes();
        }

        private Dictionary<string, Condition> GetWeatherCodes()
        {
            var codesTask = client.GetStringAsync("https://yorknation.com/codes.json");
            codesTask.Wait();

            var values = JsonConvert.DeserializeObject<Dictionary<string, Condition>>(codesTask.Result);
            if (values != null)
            {
                return values;
            }
            else
            {
                return [];
            }
        }

        private string DecodeCondition(string condition)
        {
            return WeatherCodes[condition].Day.Desc;
        }

        private void GetWeatherButton(object sender, EventArgs e)
        {
            var weatherTask = client.GetStringAsync("https://yorknation.com/data.json");
            weatherTask.Wait();

            var weatherData = JsonConvert.DeserializeObject<Weather>(weatherTask.Result);

            if (weatherData != null)
            {

                TempatureTextBox.Text = weatherData.Current.Temperature2m.ToString();

                WeatherDataGrid.Rows.Clear();

                int i = 0;
                foreach (var time in weatherData.Hourly.Time)
                {
                    string[] row = [ time.ToString(),
                                        weatherData.Hourly.Temperature2m[i].ToString(),
                                        DecodeCondition(weatherData.Hourly.WeatherCode[i].ToString())
                                    ];

                    WeatherDataGrid.Rows.Add(row);
                    i++;
                }
            }

            var tideTask = client.GetStringAsync("https://yorknation.com/tidedata.json");
            tideTask.Wait();

            var tideData = JsonConvert.DeserializeObject<Tides>(tideTask.Result);

            TidesDataGrid.Rows.Clear();
            if (tideData != null)
            {
                int i = 0;
                foreach (var tide in tideData.Data)
                {
                    string[] row = [
                                        tide.TideTime.ToLocalTime().ToString(),
                                        (tide.Height * 3.28084).ToString(),
                                        tide.Type
                                    ];

                    TidesDataGrid.Rows.Add(row);
                    i++;
                }

                StationTextBox.Text = tideData.Meta.Station.Name.ToUpper();
            }           
        }
    }
}
