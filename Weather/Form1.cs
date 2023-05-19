using System.Net;
using System.Text.Json;

namespace Weather
{
    public partial class MainForm : Form
    {
        private string api = "fec18bc5844f3964ce3a60e06a25d468";
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city = CityComboBox.Text;

            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={api}&units=metric";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                string responseData;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    responseData = reader.ReadToEnd();
                }

                // ��������� ���������� ������ � ������ (responseData)
                DisplayWeatherData(responseData);
            }
            catch (WebException ex)
            {
                // ��������� ������ �������
                MessageBox.Show("������ ��� ��������� ������ � ������: " + ex.Message);
            }
        }

        private void DisplayWeatherData(string responseData)
        {
            // �������������� JSON-������
            WeatherResponse weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(responseData);

            // ���������� ������ ������
            float temperature = weatherResponse.main.temp;
            string weatherDescription = weatherResponse.weather[0].description;
            double windSpeed = weatherResponse.wind.speed;

            // ����� ������ �� �������� ����������
            temperatureBox.Text = $"{temperature}�C";
            descritionBox.Text = weatherDescription;
            windSpeedBox.Text = $"{windSpeed.ToString("F2")} �/�";
        }
    }
}