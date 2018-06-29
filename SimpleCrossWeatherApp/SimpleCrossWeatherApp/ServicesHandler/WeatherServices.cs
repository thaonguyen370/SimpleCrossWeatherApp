using SimpleCrossWeatherApp.Models;
using SimpleCrossWeatherApp.WeatherRestClient;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace SimpleCrossWeatherApp.ServicesHandler
{
    public class WeatherServices
    {
        OpenWeatherMap<WeatherMainModel> _openWeatherRest = new OpenWeatherMap<WeatherMainModel>();
        public async Task<WeatherMainModel> GetWeatherDetails(string city)
        {
            var getWeatherDetails = await _openWeatherRest.GetAllWeathers(city);
            DateTime date;
            System.DateTime.TryParseExact((long.Parse(getWeatherDetails.dt)*1000).ToString(), "yyyyMMdd",
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out date);
            getWeatherDetails.dt = date.ToString();
            string x = "http://openweathermap.org/img/w/" + getWeatherDetails.weather[0].icon + ".png";
            getWeatherDetails.weather[0].icon = x;
            int  a=(int)(float.Parse(getWeatherDetails.main.temp)/10);
            
            getWeatherDetails.main.temp = a.ToString();
            return getWeatherDetails;
        }
    }
}