using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleCrossWeatherApp.Models
{
    // serves as our main model in centralizing different classes
    public class WeatherMainModel
    {
        [JsonProperty("name")]
        public string name { get; set; }
        public WeatherTempDetails main { get; set; }
        public List<WeatherSubDetails> weather { get; set; }
        public WeatherWindDetails wind { get; set; }
        public WeatherSysDetails sys { get; set; }
        [JsonProperty("dt")]
        public string dt { get; set; }
        public WeatherSubDetails xx { get; set; }
       
        public Clouds clouds { get; set; }
    }

    public class WeatherSubDetails
    {
        [JsonProperty("main")]
        public string main { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }//mieu tả
        [JsonProperty("icon")]
        public string icon { get; set; }

    }

    public class WeatherSysDetails
    {
        [JsonProperty("country")]
        public string country { get; set; }
    }

    public class WeatherTempDetails
    {
        [JsonProperty("temp")]
        public string temp { get; set; }//nhiệt độ
        [JsonProperty("humidity")]
        public string humidity { get; set; }//độ ẩm
    }

    public class WeatherWindDetails
    {
        [JsonProperty("speed")]
        public string speed { get; set; }

    }

    public class Clouds
    {
        [JsonProperty("all")]
        public String all{ get; set; }
    }
}