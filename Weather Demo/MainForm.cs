using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Weather_Common;
using Weather_Demo.Model;


namespace BigButtonDemo
{
    public partial class MainForm : Form
    {
        //private readonly HttpClient client = new();
        //private readonly Dictionary<string, Condition> WeatherCodes;
        private readonly GetData getData;


        public MainForm()
        {
            InitializeComponent();
            getData = new GetData();
        }

        private void GetWeatherButton(object sender, EventArgs e)
        {
            var weatherData = getData.GetWeatherData();

            if (weatherData != null)
            {

                TempatureTextBox.Text = weatherData.Current.Temperature2m.ToString();

                WeatherDataGrid.Rows.Clear();

                int i = 0;
                foreach (var time in weatherData.Hourly.Time)
                {
                    string[] row = [ time.ToString(),
                                        weatherData.Hourly.Temperature2m[i].ToString(),
                                        getData.DecodeCondition(weatherData.Hourly.WeatherCode[i].ToString())
                                    ];

                    WeatherDataGrid.Rows.Add(row);
                    i++;
                }
            }

            var tideData = getData.GetTideData();

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
