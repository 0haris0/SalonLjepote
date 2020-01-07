using eHairdresserSalon_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace eHairdresserSalon_API.Controllers
{
    public class TerminiController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        public List<Termini_Result> GetTermini()
        {
            return dm.esp_Termini_SelectAllD().ToList();
        }


        [HttpGet]
        [Route("api/Termini/{terminID}")]
        public Termini GetTermini(string terminID)
        {
            int tID = Convert.ToInt32(terminID);
            return dm.Terminis.Where(x => x.TerminID == tID).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Termini/SearchByFrizer/{frizerID}")]
        public List<Termini_Result2> SearchByFrizer(string frizerID)
        {

            return dm.esp_Termini_GetSlobodniByFrizer(Convert.ToInt32(frizerID)).ToList();
        }

        [HttpGet]
        [Route("api/Termini/SearchByAktivniTermini/{terminID?}")]
        public List<Termini_Result> SearchByAktivniTermini()
        {

            return dm.esp_Termini_GetAktivniTermini().ToList();
        }


        [HttpGet]
        [Route("api/Termini/SearchByKlijent/{klijentID}")]
        public List<Termini_Result3> SearchByKlijent(string klijentID)
        {
            return dm.esp_Termini_GetTerminiByKlijent(Convert.ToInt32(klijentID)).ToList();
        }



        [ResponseType(typeof(Termini))]
        public IHttpActionResult PostTermini(Termini obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dm.Terminis.Add(obj);

            dm.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = obj.TerminID }, obj);
        }

        [HttpGet]
        [Route("api/Termini/SearchByDate/{datum}")] 
        public List<Termini_Result> SearchByDate(string datum)
        {
            DateTime date = Convert.ToDateTime(datum);
            return dm.esp_Termini_SelectByDatum(date).ToList();
        }

        [ResponseType(typeof(void))]
        [Route("api/Termini/{id}")]
        public IHttpActionResult PutTermini(int id, Termini t)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != t.TerminID)
                return BadRequest();

            dm.esp_Termini_Update(id,t.Datum,t.Vrijeme,t.KlijentID,t.FrizerID,t.UslugaID, t.Zauzeto, t.TretmanID, t.OcijenjenaUsluga, t.OcijenjenTretman, t.prosaoTermin);

            dm.SaveChanges();
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
