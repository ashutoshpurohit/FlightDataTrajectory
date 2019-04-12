using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class AirFlight
    {
        public String FlightId;
        public String Source;
        public String Destination;
        public DateTime FlightDate;
        public List<FlightPath> AirFlightPath;
        public String FlightDateStr;
    }

    public class FlightPath
    {
        public double Latitude;
        public double Longitude;
        public double Altitude;
        public double Speed;
        public double Direction;
        public String TimeSlice;
        public double TimeStamp;

        public override string ToString()
        {
            return ("Latitude: " + this.Latitude.ToString() + Environment.NewLine + " Longitude: " + this.Longitude.ToString() + Environment.NewLine
                + " Altitude: " + this.Altitude.ToString() + Environment.NewLine + " Speed: " + this.Speed.ToString() + Environment.NewLine
                + " Direction: " + this.Direction.ToString() + Environment.NewLine + " TimeSlice: " + this.TimeSlice + Environment.NewLine
                + " TimeStamp: " + this.TimeStamp.ToString());
        }
    }
}
