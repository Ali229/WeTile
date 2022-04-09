using System;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace WeTile
{
    internal class AirQuality
    {
        public string URL { get; set; }
        public string XML { get; set; }

        XmlDocument Doc = new XmlDocument();
        public async Task<bool> GetAirQuality(double Latitude, double Longitude)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = String.Format("http://api.openweathermap.org/data/2.5/air_pollution?lat={0}&lon={1}&appid={2}", Latitude, Longitude, "a1916e5365462ceb65cfa9bb0606d1d8");
                    string JSON = webClient.DownloadString("");


                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
