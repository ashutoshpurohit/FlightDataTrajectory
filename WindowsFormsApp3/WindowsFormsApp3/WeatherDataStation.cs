using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class WeatherDataStation
    {
        private Metars metars;

        public Metars getMetars()
        {
            return metars;
        }

        public void setMetars(Metars metars)
        {
            this.metars = metars;
        }
    }
}
