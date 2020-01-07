using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace eHairdresserSalon_API.Util
{
    public class ExceptionFilter:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if(actionExecutedContext.Exception is NotImplementedException)
            {
                HttpResponseMessage msg = new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.PaymentRequired,
                    ReasonPhrase = "Uplata obavezna!",
                    Content = new StringContent("Potrebno izvrsiti uplatu!")
                };
                actionExecutedContext.Response = msg;
            }
            base.OnException(actionExecutedContext);
        }
    }
}