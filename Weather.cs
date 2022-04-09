﻿using System;
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
        public double Temperature { get; set; }
        public string Url { get; set; }
        public string WeatherIcon { get; set; }
        public string WeatherName { get; set; }
        public string XML { get; set; }

        public async Task<bool> GetWeather()
        {

            City = Properties.Settings.Default.citySetting;
            Url = "http://api.openweathermap.org/data/2.5/weather?q=" + City + "&APPID=8f4ab9a3d1172fae3aa81d236689dfc6&mode=xml&units="
            + (Properties.Settings.Default.unitSetting == "C" ? "metric" : "imperial");
            Console.WriteLine(Url);
            XML = await new WebClient().DownloadStringTaskAsync(new Uri(Url));
            Doc.LoadXml(XML);

            Temperature = double.Parse(Doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value);
            WeatherName = Doc.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;
            City = Doc.DocumentElement.SelectSingleNode("city").Attributes["name"].Value;
            WeatherIcon = Doc.DocumentElement.SelectSingleNode("weather").Attributes["number"].Value;

            await Task.Delay(1000);
            return Connection = true;
        }
    }
}