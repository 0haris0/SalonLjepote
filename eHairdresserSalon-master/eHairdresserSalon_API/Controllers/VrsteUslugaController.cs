using eHairdresserSalon_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eHairdresserSalon_API.Controllers
{
    public class VrsteUslugaController : ApiController
    {

        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        //api/VrsteUsluga
        public List<VrsteUsluga_Result> GetVrsteUsluga()
        {
            return dm.esp_VrsteUsluga_SelectAll().ToList();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dm.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
