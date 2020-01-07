using eHairdresserSalon_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace eHairdresserSalon_API.Controllers
{
    public class KlijentiTakmicenjaController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        [Route("api/KlijentiTakmicenja/SearchByKlijent/{klijentID}")]
        public List<Takmicenja_Result> SearchByKlijent(string klijentID)
        {

            return dm.esp_Takmicenja_GetTakmicenjaByKlijent(Convert.ToInt32(klijentID)).ToList();
        }

        [ResponseType(typeof(KlijentiTakmicenja))]
        public IHttpActionResult PostKlijentiTakmicenja(KlijentiTakmicenja obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dm.KlijentiTakmicenja.Add(obj);
            dm.SaveChanges();

            return Ok(obj);
        }
    }
}
