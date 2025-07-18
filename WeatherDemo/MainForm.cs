using CoordinateSharp;
using WeatherCommon.Model;
using WeatherCommon;


namespace WeatherDemo
{
    public partial class MainForm : Form
    {
        private readonly GetData getData;

        public MainForm()
        {
            InitializeComponent();
            getData = new GetData();
        }

        private void GetWeatherButton(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            Weather weatherData = getData.GetWeatherData();

            if (weatherData != null)
            {

                TempatureTextBox.Text = weatherData.Current.Temperature2m.ToString();

                WeatherDataGrid.Rows.Clear();

                int i = 0;
                int selectedRow = 0;
                foreach (var time in weatherData.Hourly.Time)
                {
                    Coordinate coordinate = new(weatherData.Latitude, weatherData.Longitude, time.ToUniversalTime());

                    string[] rowData = [
                                         time.ToString(),
                                         weatherData.Hourly.Temperature2m[i].ToString(),
                                         getData.DecodeCondition(weatherData.Hourly.WeatherCode[i].ToString(), 
                                                                 coordinate.CelestialInfo.IsSunUp)
                                       ];

                    WeatherDataGrid.Rows.Add(rowData);

                    if (time <= now)
                    {
                        selectedRow = i;
                    }

                    WeatherDataGrid.ClearSelection();
                    WeatherDataGrid.Rows[selectedRow].Selected = true;

                    i++;
                }
            }

            var tideData = getData.GetTideData();

            
            if (tideData != null)
            {
                StationTextBox.Text = tideData.Meta.Station.Name.ToUpper();

                TidesDataGrid.Rows.Clear();

                int i = 0;
                int selectedRow = 0;
                foreach (var tide in tideData.Data)
                {
                    var time = tide.TideTime.ToLocalTime();

                    string[] rowData = [
                                        time.ToString(),
                                        (tide.Height * 3.28084).ToString(),
                                        tide.Type
                                       ];

                    TidesDataGrid.Rows.Add(rowData);

                    i++;

                    if (time <= now)
                    {
                        selectedRow = i;
                    }
                }

                TidesDataGrid.ClearSelection();
                TidesDataGrid.Rows[selectedRow].Selected = true;

            }           
        }
    }
}
