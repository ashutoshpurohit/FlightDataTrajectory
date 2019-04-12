using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Http;
using Newtonsoft.Json;
using System.Configuration;
using System.Net;


namespace WindowsFormsApp3
{
    public class RestAPIManager
    {

        private HttpClient _httpClient;
        private string _baseaddress;

        public RestAPIManager()
        {
            string baseaddress = ConfigurationManager.AppSettings["baseaddress"];

            int connectionlimit = int.Parse(ConfigurationManager.AppSettings["DefaultConnectionLimit"]);

            if (!baseaddress.EndsWith(@"/"))
            {
                baseaddress = baseaddress + @"/";
            }
            _baseaddress = baseaddress;

            _httpClient = new HttpClient
            {

                BaseAddress = new Uri(baseaddress)
            };
            _httpClient.DefaultHeaders.Accept.Add("application/json");
            ServicePointManager.DefaultConnectionLimit = connectionlimit;


        }

        public void CloseOrDispose()
        {
            if (_httpClient != null)
            {

                _httpClient.Dispose();
            }
        }

        public string GetBaseAddress()
        {
            if (!string.IsNullOrEmpty(_baseaddress))
            {
                return _baseaddress;
            }
            else
            {
                string baseaddress = ConfigurationManager.AppSettings["baseaddress"];
                if (!baseaddress.EndsWith(@"/"))
                {
                    baseaddress = baseaddress + @"/";
                }
                return _baseaddress;
            }
        }

        private HttpResponseMessage Get(string uri)
        {
            return _httpClient.Send(HttpMethod.GET, uri);
        }

        public HttpResponseMessage Delete(string uri)
        {
            return _httpClient.Send(HttpMethod.DELETE, uri);
        }

        public T Get<T>(string uri)
        {
            HttpResponseMessage response = Get(uri);
            return Unwrap<T>(response);
        }


        public T Unwrap<T>(HttpResponseMessage response)
        {
            string content = response.Content.ReadAsString();

            return JsonConvert.DeserializeObject<T>(content);

        }

        public string Wrap<T>(T objectdata)
        {
            string json = string.Empty;
            json = JsonConvert.SerializeObject(objectdata);
            return json;
        }

        public HttpResponseMessage Put<String, T>(string uri, T objectdata)
        {
            string jsondata = Wrap(objectdata);
            return Put(uri, jsondata);
        }

        public HttpResponseMessage Post<String, T>(string uri, T objectdata)
        {
            string jsondata = Wrap(objectdata);
            return Post(uri, jsondata);
        }

        private HttpResponseMessage Put(string uri, string jsondata)
        {
            HttpResponseMessage response = _httpClient.Send(HttpMethod.PUT,
                            uri,
                            HttpContent.Create(jsondata, "application/json"));
            return response;
        }

        private HttpResponseMessage Post(string uri, string jsondata)
        {
            HttpResponseMessage response = _httpClient.Send(HttpMethod.POST,
                            uri,
                            HttpContent.Create(jsondata, "application/json"));
            return response;
        }



    }
}
