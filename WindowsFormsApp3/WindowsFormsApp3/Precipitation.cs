using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Precipitation
    {
        private probability chances;

        public probability getChances()
        {
            return chances;
        }

        public void setProbability(probability chances)
        {
            this.chances = chances;
        }
    }
}
