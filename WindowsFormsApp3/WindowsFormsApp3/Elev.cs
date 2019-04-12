using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Elev
    {
        private String units;

        private double value;

        public String getUnits()
        {
            return units;
        }

        public void setUnits(String units)
        {
            this.units = units;
        }

        public double getValue()
        {
            return value;
        }

        public void setValue(double value)
        {
            this.value = value;
        }
    }
}
