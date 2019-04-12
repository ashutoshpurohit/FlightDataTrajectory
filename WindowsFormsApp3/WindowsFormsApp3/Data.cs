using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Data
    {
        private Precipitation precipitation;

        private String daylight;

        private Temperature temperature;

        private Cloud_cover cloud_cover;

        private Relative_humidity relative_humidity;

        private Weather_code weather_code;

        private String valid_begin;

        private Wind wind;

        public Precipitation getPrecipitation()
        {
            return precipitation;
        }

        public void setPrecipitation(Precipitation precipitation)
        {
            this.precipitation = precipitation;
        }

        public String getDaylight()
        {
            return daylight;
        }

        public void setDaylight(String daylight)
        {
            this.daylight = daylight;
        }

        public Temperature getTemperature()
        {
            return temperature;
        }

        public void setTemperature(Temperature temperature)
        {
            this.temperature = temperature;
        }

        public Cloud_cover getCloud_cover()
        {
            return cloud_cover;
        }

        public void setCloud_cover(Cloud_cover cloud_cover)
        {
            this.cloud_cover = cloud_cover;
        }

        public Relative_humidity getRelative_humidity()
        {
            return relative_humidity;
        }

        public void setRelative_humidity(Relative_humidity relative_humidity)
        {
            this.relative_humidity = relative_humidity;
        }

        public Weather_code getWeather_code()
        {
            return weather_code;
        }

        public void setWeather_code(Weather_code weather_code)
        {
            this.weather_code = weather_code;
        }

        public String getValid_begin()
        {
            return valid_begin;
        }

        public void setValid_begin(String valid_begin)
        {
            this.valid_begin = valid_begin;
        }

        public Wind getWind()
        {
            return wind;
        }

        public void setWind(Wind wind)
        {
            this.wind = wind;
        }
    }
}
