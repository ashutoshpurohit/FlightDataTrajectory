using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Cloud_cover
    {
        private String units;

        private String text;

        private String value;

        public String getUnits()
        {
            return units;
        }

        public void setUnits(String units)
        {
            this.units = units;
        }

        public String getText()
        {
            return text;
        }

        public void setText(String text)
        {
            this.text = text;
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
