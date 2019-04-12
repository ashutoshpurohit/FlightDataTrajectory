using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Http;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    public class DataManager
    {
        public const string AirFlightUrl = "AirFlight";
        public const string AirFlightUrl1 = "GetAirFlight/AIC173";

        private RestAPIManager _apimanager;

        public DataManager()
        {
            _apimanager = new RestAPIManager();
        }

        private string GetBaseURL()
        {
            return _apimanager.GetBaseAddress();
        }

        public AirFlight[] GetAirFlight()
        {
            AirFlight[] flights;
            string flightsuri = GetBaseURL() + AirFlightUrl;
            flights = _apimanager.Get<AirFlight[]>(flightsuri);
            _apimanager.CloseOrDispose();
            return flights;
        }

        public GeneralResponse AddAirFlighty(AirFlight flight)
        {
            string flightsuri = GetBaseURL() + AirFlightUrl;
            HttpResponseMessage HttpResp = _apimanager.Put<String, AirFlight>(flightsuri, flight);
            GeneralResponse resp = _apimanager.Unwrap<GeneralResponse>(HttpResp);

            _apimanager.CloseOrDispose();
            return resp;
        }

        public GeneralResponse UpdateAirFlight(AirFlight flight)
        {
            string flightsuri = GetBaseURL() + AirFlightUrl;
            HttpResponseMessage HttpResp = _apimanager.Post<String, AirFlight>(flightsuri, flight);
            GeneralResponse resp = _apimanager.Unwrap<GeneralResponse>(HttpResp);

            _apimanager.CloseOrDispose();
            return resp;
        }

    }
}
