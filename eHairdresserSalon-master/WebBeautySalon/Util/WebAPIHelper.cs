using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebBeautySalon.Util
{
    public class WebAPIHelper
    {

        public HttpClient client { get; set; }
        public string route { get; set; }

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
        public HttpResponseMessage GetResponse(string parametar)
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, bool parameter)
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, string parameter1, string parameter2)
        {
            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, bool parameter1, string parameter2, string parameter3)
        {
            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2 + "/" + parameter3).Result;
        }

        public HttpResponseMessage PostActionResponse(string action, Object obj)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return client.PostAsync(route + "/" + action + "/" + 1, jsonObject).Result;
        }

        public HttpResponseMessage PostResponse(Object obj)
        {
            return client.PostAsJsonAsync(route, obj).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }

        public HttpResponseMessage DeleteResponse(string id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }
    }
}
