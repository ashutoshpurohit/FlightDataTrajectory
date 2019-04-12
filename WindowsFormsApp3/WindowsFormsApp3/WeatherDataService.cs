using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class WeatherDataService
    {
        public double latitude;
        public double longitude;
        public double altitude;
        public String DateStr;
        public String TimeStr;
        public Temperature temperature;
        public Relative_humidity relative_humidity;
        public Cloud_cover cloud_cover;
        public Weather_code weather_code;
        public Cloud_ceiling cloud_ceiling;
        public Pressure pressure;
        public bool daylight;
        public Visibility visibility;
        public Wind wind;
        public Precipitation precipitation;
        public Station station;
        public DateTime issuetime;
    }
}
