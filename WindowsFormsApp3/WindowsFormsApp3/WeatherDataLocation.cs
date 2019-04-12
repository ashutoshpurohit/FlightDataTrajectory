using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class WeatherDataLocation
    {
        private Ndfd_hourly ndfd_hourly;

        public Ndfd_hourly getNdfd_hourly()
        {
            return ndfd_hourly;
        }

        public void setNdfd_hourly(Ndfd_hourly ndfd_hourly)
        {
            this.ndfd_hourly = ndfd_hourly;
        }
    }
}
