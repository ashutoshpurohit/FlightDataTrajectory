using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Temperature
    {
        private String dew_point;

        private String units;

        private String value;

        public String getDew_point()
        {
            return dew_point;
        }

        public void setDew_point(String dew_point)
        {
            this.dew_point = dew_point;
        }

        public String getUnits()
        {
            return units;
        }

        public void setUnits(String units)
        {
            this.units = units;
        }

        public String getValue()
        {
            return value;
        }

        public void setValue(String value)
        {
            this.value = value;
        }
    }
}
