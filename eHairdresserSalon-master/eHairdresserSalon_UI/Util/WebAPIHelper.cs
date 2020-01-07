using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using eHairdresserSalon_API.Models;

namespace eHairdresserSalon_UI.Util
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

        public HttpResponseMessage GetResponse(string parameter)
        {
            return client.GetAsync(route + "/" + parameter).Result;
        }


        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage PostResponse(Object newObject)
        {
            return client.PostAsJsonAsync(route, newObject).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }
    }
}
