using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Station
    {
        private Elev elev;

        private double[] coordinates;

        private String name;

        private String id;

        private int priority;

        public Elev getElev()
        {
            return elev;
        }

        public void setElev(Elev elev)
        {
            this.elev = elev;
        }

        public double[] getCoordinates()
        {
            return coordinates;
        }

        public void setCoordinates(double[] coordinates)
        {
            this.coordinates = coordinates;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getId()
        {
            return id;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public int getPriority()
        {
            return priority;
        }

        public void setPriority(int priority)
        {
            this.priority = priority;
        }
    }
}
