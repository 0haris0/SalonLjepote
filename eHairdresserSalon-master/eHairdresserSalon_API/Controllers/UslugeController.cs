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
    public class UslugeController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        public List<Usluge_Result> GetUsluge()
        {
            return dm.esp_Usluge_SelectAll().OrderBy(x => x.UslugaID).ToList();
        }

        [HttpGet]
        [Route("api/Usluge/{uslugaID}")]
        public Usluge GetUsluge(string uslugaID)
        {
            int uID = Convert.ToInt32(uslugaID);
            return dm.Usluge.Where(x => x.UslugaID == uID).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Usluge/SearchByVrstaUsluge/{vrstaUslugeID}")]
        public List<Usluge_Result> SearchByVrstaUsluge(int vrstaUslugeID)
        {
            return dm.esp_Usluge_SelectByVrstaUsluge(vrstaUslugeID).ToList();
        }

        [HttpGet]
        [Route("api/Usluge/SearchByUsluga/{uslugaID}")]
        public List<Usluge> SearchByUsluga(string uslugaID)
        {
            int uID = Convert.ToInt32(uslugaID);
            return dm.Usluge.Where(x => x.UslugaID == uID).ToList();
        }

        [ResponseType(typeof(Usluge))]
        public IHttpActionResult PostUsluge(Usluge obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Usluge.Add(obj);
            dm.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = obj.UslugaID }, obj);
        }


        [HttpGet]
        [Route("api/Usluge/SearchByName/{name?}")]
        public List<Usluge_Result> SearchByName(string name = "")
        {
            return dm.esp_Usluge_SelectByNaziv(name).ToList();
        }

        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/Usluge/{id}")]
        public IHttpActionResult PutUsluge(int id, Usluge u)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != u.UslugaID)
                return BadRequest();

            dm.esp_Usluge_Update(id, u.NazivUsluge, u.TrajanjeMinute, u.CijenaUsluge,u.VrstaUslugeID);

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
