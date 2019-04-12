using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Wind
    {
        private String dir_units;

        private String speed_units;

        private String dir;

        private String speed;

        public String getDir_units()
        {
            return dir_units;
        }

        public void setDir_units(String dir_units)
        {
            this.dir_units = dir_units;
        }

        public String getSpeed_units()
        {
            return speed_units;
        }

        public void setSpeed_units(String speed_units)
        {
            this.speed_units = speed_units;
        }

        public String getDir()
        {
            return dir;
        }

        public void setDir(String dir)
        {
            this.dir = dir;
        }

        public String getSpeed()
        {
            return speed;
        }

        public void setSpeed(String speed)
        {
            this.speed = speed;
        }
    }
}
