using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Metars
    {
        private WeatherData data;

        public WeatherData getData()
        {
            return data;
        }

        public void setData(WeatherData data)
        {
            this.data = data;
        }
    }
}
