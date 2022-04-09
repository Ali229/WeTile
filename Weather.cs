using System;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace WeTile
{
    public class Weather
    {

        public string City { get; set; }
        public bool Connection;
        XmlDocument Doc = new XmlDocument();
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Temperature { get; set; }
        public DateTime Timestamp { get; set; }
        public string URL { get; set; }
        public string WeatherIcon { get; set; }
        public string WeatherName { get; set; }
        public string XML { get; set; }

        public async Task<bool> GetWeather()
        {

            City = Properties.Settings.Default.citySetting;
            URL = "http://api.openweathermap.org/data/2.5/weather?q=" + City + "&APPID=a1916e5365462ceb65cfa9bb0606d1d8&mode=xml&units="
            + (Properties.Settings.Default.unitSetting == "C" ? "metric" : "imperial");
            XML = await new WebClient().DownloadStringTaskAsync(new Uri(URL));
            Doc.LoadXml(XML);
            Timestamp = DateTime.Now;

            XmlElement Element = Doc.DocumentElement;
            Temperature = double.Parse(Element.SelectSingleNode("temperature").Attributes["value"].Value);
            WeatherName = Element.SelectSingleNode("weather").Attributes["value"].Value;
            City = Element.SelectSingleNode("city").Attributes["name"].Value;
            WeatherIcon = Element.SelectSingleNode("weather").Attributes["number"].Value;
            Latitude = double.Parse(Element.SelectSingleNode("city/coord").Attributes["lat"].Value);
            Longitude = double.Parse(Element.SelectSingleNode("city/coord").Attributes["lon"].Value);

            await Task.Delay(1000);
            return Connection = true;
        }
    }
}
