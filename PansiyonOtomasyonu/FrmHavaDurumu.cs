using System;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;

namespace PansiyonOtomasyonu
{
    public partial class FrmHavaDurumu : Form
    {
        private const string API_KEY = "6b81b57c285b5600a41fa354e628c358";
        private const string API_ENDPOINT = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=tr";

        public FrmHavaDurumu()
        {
            InitializeComponent();
        }

        private void FrmHavaDurumu_Load(object sender, EventArgs e)
        {
            GetWeather("Istanbul", label1, label2);
            GetWeather("Samsun", label3, label4);
            GetWeather("Niğde", label11, label12);
            GetWeather("Ankara", label5, label6);
            GetWeather("İzmir", label7, label8);
            GetWeather("Diyarbakır", label9, label10);
           

        }//

        private void GetWeather(string city, Label descriptionLabel, Label temperatureLabel)
        {
            string apiUrl = string.Format(API_ENDPOINT, city, API_KEY);

            try
            {
                using (WebClient webClient = new WebClient { Encoding = Encoding.UTF8 })
                {
                    string jsonData = webClient.DownloadString(apiUrl);

                    // JSON verisini çözümle
                    dynamic result = JObject.Parse(jsonData);

                    // Hava durumu bilgilerini al
                    string aciklama = result.weather[0].description;
                    string sicaklik = result.main.temp + " °C";

                    // Label kontrolüne bilgileri yerleştir
                    descriptionLabel.Text = $"Hava Durumu: {aciklama}";
                    temperatureLabel.Text = $"Sıcaklık: {sicaklik}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hava durumu bilgisi alınırken bir hata oluştu: {ex.Message}");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
