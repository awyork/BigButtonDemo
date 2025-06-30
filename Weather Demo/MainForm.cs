using BigButtonDemo.Model;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace BigButtonDemo
{
    public partial class MainForm : Form
    {
        private readonly HttpClient client = new HttpClient();
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
            return values;
        }

        private string DecodeCondition(string condition)
        {
            return WeatherCodes[condition].day.desc;
        }

        private void GetWeatherButton(object sender, EventArgs e)
        {
            var weatherTask = client.GetStringAsync("https://yorknation.com/data.json");
            weatherTask.Wait();

            var deserializeSourceData = JsonConvert.DeserializeObject<Weather>(weatherTask.Result);

            TempatureTextBox.Text = deserializeSourceData.current.temperature_2m.ToString();

            dataGridView1.Rows.Clear();


            int i = 0;
            foreach (var time in deserializeSourceData.hourly.time)
            {
                string[] row = new string[] { time, 
                                              deserializeSourceData.hourly.temperature_2m[i].ToString(),
                                              DecodeCondition(deserializeSourceData.hourly.weather_code[i].ToString())};
                dataGridView1.Rows.Add(row);
                i++;
            }

        }
    }
}
