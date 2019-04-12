using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class WeatherData
    {
        private Visibility visibility;

        private String daylight;

        private String issuetime;

        private Temperature temperature;

        private Cloud_cover cloud_cover;

        private Station station;

        private Pressure pressure;

        private String raw_metar;

        private Relative_humidity relative_humidity;

        private Cloud_ceiling cloud_ceiling;

        private Weather_code weather_code;

        private Wind wind;

        public Visibility getVisibility()
        {
            return visibility;
        }

        public void setVisibility(Visibility visibility)
        {
            this.visibility = visibility;
        }

        public String getDaylight()
        {
            return daylight;
        }

        public void setDaylight(String daylight)
        {
            this.daylight = daylight;
        }

        public String getIssuetime()
        {
            return issuetime;
        }

        public void setIssuetime(String issuetime)
        {
            this.issuetime = issuetime;
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

        public Station getStation()
        {
            return station;
        }

        public void setStation(Station station)
        {
            this.station = station;
        }

        public Pressure getPressure()
        {
            return pressure;
        }

        public void setPressure(Pressure pressure)
        {
            this.pressure = pressure;
        }

        public String getRaw_metar()
        {
            return raw_metar;
        }

        public void setRaw_metar(String raw_metar)
        {
            this.raw_metar = raw_metar;
        }

        public Relative_humidity getRelative_humidity()
        {
            return relative_humidity;
        }

        public void setRelative_humidity(Relative_humidity relative_humidity)
        {
            this.relative_humidity = relative_humidity;
        }

        public Cloud_ceiling getCloud_ceiling()
        {
            return cloud_ceiling;
        }

        public void setCloud_ceiling(Cloud_ceiling cloud_ceiling)
        {
            this.cloud_ceiling = cloud_ceiling;
        }

        public Weather_code getWeather_code()
        {
            return weather_code;
        }

        public void setWeather_code(Weather_code weather_code)
        {
            this.weather_code = weather_code;
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
