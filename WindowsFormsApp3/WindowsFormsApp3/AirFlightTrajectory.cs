using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class AirFlightTrajectory
    {
        public string FlightId;
        public string SourceCity;
        public string DestinationCity;
        public List<AirCraftPath> AirCraftPaths;
    }

    public class AirCraftPath
    {
        public List<AirCraftPathPlot> AirPathPlots;
    }

    public class AirCraftPathPlot
    {
        public double longitute;
        public double laltitude;
        public double altitute;
        public double speed;
        public double direction;
    }

    
}
 