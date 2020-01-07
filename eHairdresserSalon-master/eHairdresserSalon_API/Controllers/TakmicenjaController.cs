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
    public class TakmicenjaController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        public List<Takmicenja_Result> GetKTakmicenja()
        {
            return dm.esp_Takmicenja_SelectAll().ToList();
        }

        [HttpGet]
        [Route("api/Takmicenja/{takmicenjeID}")]
        public Takmicenja GetTakmicenja(string takmicenjeID)
        {
            int tID = Convert.ToInt32(takmicenjeID);
            return dm.Takmicenjas.Where(x => x.TakmicenjeID == tID).FirstOrDefault();
        }



        [HttpGet]
        [Route("api/Takmicenja/GetKlijentiByTakmicenje/{takmicenjeID}")]
        public List<Takmicenja_Report> GetKlijentiByTakmicenje(string takmicenjeID)
        {
            return dm.esp_Takmicenja_GetPrijavljeniByTakmicenje(Convert.ToInt32(takmicenjeID)).ToList();
        }


        [HttpGet]
        [Route("api/Takmicenja/GetTakmicenjaByDatum/{klijentID}")]
        public List<Takmicenja> GetTakmicenjaByDatum(string klijentID)
        {
            int kID = Convert.ToInt32(klijentID);
            return dm.esp_Takmicenja_GetTakmicenjaByDatum(kID).ToList();
        }

        [HttpGet]
        [Route("api/Takmicenja/SearchByKlijent/{klijentID}")]
        public List<Takmicenja_Result> SearchByKlijent(string klijentID)
        {

            return dm.esp_Takmicenja_GetTakmicenjaByKlijent(Convert.ToInt32(klijentID)).ToList();
        }

        [ResponseType(typeof(Takmicenja))]
        public IHttpActionResult PostTakmicenja(Takmicenja obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dm.Takmicenjas.Add(obj);
            dm.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = obj.TakmicenjeID }, obj);
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = code,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };

            return new HttpResponseException(msg);
        }

        [HttpGet]
        [Route("api/Takmicenja/SearchByPlace/{place?}")]
        public List<Takmicenja_Result> SearchByMjesto(string place = "")
        {
            return dm.esp_Takmicenja_SelectByMjesto(place).ToList();
        }

        [ResponseType(typeof(void))]
        [Route("api/Takmicenja/{id}")]
        public IHttpActionResult PutTakmicenja(int id, Takmicenja t)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != t.TakmicenjeID)
                return BadRequest();

            dm.esp_Takmicenja_Update(id, t.Naziv, t.Datum, t.Mjesto, t.Opis, t.FrizerID);

            return StatusCode(HttpStatusCode.NoContent);
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
