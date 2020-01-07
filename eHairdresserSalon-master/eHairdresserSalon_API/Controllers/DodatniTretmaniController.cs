using eHairdresserSalon_API.Models;
using eHairdresserSalon_API.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace eHairdresserSalon_API.Controllers
{
    public class DodatniTretmaniController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        public List<DodatniTretmani_Result> GetDodatniTretmani()
        {
            return dm.esp_DodatniTretmani_SelectAll().OrderBy(x => x.TretmanID).ToList();
        }

        [HttpGet]
        [Route("api/DodatniTretmani/SearchByID/{tretmanID}")]
        public DodatniTretmani_Ocjene_Result SearchByID(int tretmanID)
        {
            return dm.esp_DodatniTretmani_SearchByID(tretmanID).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/DodatniTretmani/SearchByVrstaUsluge/{vrstaUslugeID}")]
        public List<DodatniTretmani_Ocjene_Result> SearchByVrstaUsluge(int vrstaUslugeID)
        {
            return dm.esp_DodatniTretmaniOcjene_SelectTretmanByVrstaUsluge(vrstaUslugeID).ToList();
        }

        [HttpGet]
        [Route("api/DodatniTretmani/GetTretmaniOcjene")]
        public List<DodatniTretmani_Ocjene_Result> GetTretmaniOcjene()
        {
            return dm.esp_DodatniTretmani_Ocjene().ToList();
        }

        [HttpGet]
        [Route("api/DodatniTretmani/{tretmaniD}")]
        public DodatniTretmani GetDodatniTretmani(string tretmaniD)
        {
            int tID = Convert.ToInt32(tretmaniD);
            return dm.DodatniTretmanis.Where(x => x.TretmanID == tID).FirstOrDefault();
        }

        [ResponseType(typeof(DodatniTretmani))]
        public IHttpActionResult PostDodatniTretmani(DodatniTretmani obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dm.DodatniTretmanis.Add(obj);

            dm.SaveChanges();
            return Ok(obj);
        }

        [HttpGet]
        [Route("api/DodatniTretmani/PreporukaDodatnihTretmana/{klijentID}/{tretmanID}/{vrstaUslugeID}")]
        public List<DodatniTretmani_Ocjene_Result> PreporukaDodatnihTretmana(int klijentID, int tretmanID, int vrstaUslugeID)
        {
            Recommender r = new Recommender();
            return r.GetSlicneProizvode(klijentID, tretmanID, vrstaUslugeID);
        }

        [HttpGet]
        [Route("api/DodatniTretmani/SearchByName/{name?}")]
        public List<DodatniTretmani_Result> SearchByName(string name = "")
        {
            return dm.esp_DodatniTretmani_SelectByNaziv(name).ToList();
        }


        [ResponseType(typeof(void))]
        [Route("api/DodatniTretmani/{id}")]
        public IHttpActionResult PutDodatniTretmani(int id, DodatniTretmani t)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != t.TretmanID)
                return BadRequest();

            dm.esp_DodatniTretmani_Update(id, t.NazivTretmana, t.Cijena, t.VrstaUslugeID);

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
