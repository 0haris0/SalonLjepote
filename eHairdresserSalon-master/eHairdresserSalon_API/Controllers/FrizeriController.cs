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
    public class FrizeriController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();
        //naida
        [HttpGet]
        public List<Frizeri_Result> GetFrizeri()
        {
            return dm.esp_Frizeri_SelectAll().OrderBy(x => x.FrizerID).ToList();
        }

        [HttpGet]
        [Route("api/Frizeri/SearchByVrstaUsluge/{vrstaUslugeID}")]
        public List<Frizeri_Result> SearchByVrstaUsluge(int vrstaUslugeID)
        {
            return dm.esp_Frizeri_SelectUposlenikByVrstaUsluge(vrstaUslugeID).ToList();
        }

        [HttpGet]
        [Route("api/Frizeri/{frizerID}")]
        public Frizeri GetFrizeri(string frizerID)
        {
            int fID = Convert.ToInt32(frizerID);
            return dm.Frizeris.Where(x => x.FrizerID == fID).FirstOrDefault();
        }

        [ResponseType(typeof(Frizeri))]
        [Route("api/Frizeri/GetByUsername/{username}")]
        public IHttpActionResult GetByUsername(string username)
        {
            Frizeri frizeri = dm.esp_Frizeri_SelectByKorisnickoIme(username).FirstOrDefault();

            if (frizeri == null)
            {
                return NotFound();
            }

            return Ok(frizeri);
        }


        [ResponseType(typeof(Frizeri))]
        public IHttpActionResult PostFrizeri(Frizeri obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dm.Frizeris.Add(obj);
            dm.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = obj.FrizerID }, obj);
        }

        [ResponseType(typeof(void))]
        [Route("api/Frizeri/{id}")]
        public IHttpActionResult PutFrizeri(int id, Frizeri f)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != f.FrizerID)
                return BadRequest();

            dm.esp_Frizeri_Update(id, f.Ime, f.Prezime, f.KorisnickoIme, f.LozinkaSalt, f.LozinkaHash,f.Opis, f.ProfilnaSlika, f.SlikaThumb,f.VrstaUslugeID);

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
