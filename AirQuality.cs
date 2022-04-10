using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeTile
{
    public class AirQuality
    {
        public Coord Coord { get; set; }
        public List[] List { get; set; }
        public string AQIText { get; set; }
        public DateTime DTime { get; set; }
        public static async Task<AirQuality> GetAirQuality(double Latitude, double Longitude)
        {
            try
            {
                HttpClient client = new HttpClient();
                string URL = String.Format("http://api.openweathermap.org/data/2.5/air_pollution?lat={0}&lon={1}&appid={2}", Latitude, Longitude, "a1916e5365462ceb65cfa9bb0606d1d8");
                string reponse = await client.GetStringAsync(URL);

                AirQuality Quality = new AirQuality();
                Quality = JsonConvert.DeserializeObject<AirQuality>(reponse);

                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                Quality.DTime = dateTime.AddSeconds(Quality.List[0].DT).ToLocalTime();

                return Quality;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
    public class Coord
    {
        public float Lon { get; set; }
        public float Lat { get; set; }
    }

    public class List
    {
        public Main Main { get; set; }
        public Components Components { get; set; }
        public int DT { get; set; }
    }

    public class Main
    {
        public int AQI { get; set; }
    }
    public class Components
    {
        public float CO { get; set; }
        public float NO { get; set; }
        public float NO2 { get; set; }
        public float O3 { get; set; }
        public float SO2 { get; set; }
        public float PM2_5 { get; set; }
        public float PM10 { get; set; }
        public float NH3 { get; set; }
    }
}
