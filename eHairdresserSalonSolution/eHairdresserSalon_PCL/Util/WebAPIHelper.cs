using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eHairdresserSalon_PCL.Util
{
    public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }

        public HttpResponseMessage GetResponse(string parameter = "")
        {
            return client.GetAsync(route + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter1, string parameter2)
        {
            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter1, string parameter2, string parameter3)
        {
            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2 + "/" + parameter3).Result;
        }

        public HttpResponseMessage PostResponse(Object newObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(newObject), Encoding.UTF8, "application/json");
            return client.PostAsync(route, jsonObject).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            StringContent jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject),
                   Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }
    }
}
