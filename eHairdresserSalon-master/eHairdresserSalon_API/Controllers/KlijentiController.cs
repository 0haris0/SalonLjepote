using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eHairdresserSalon_API.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core;
using eHairdresserSalon_API.Util;

namespace eHairdresserSalon_API.Controllers
{
    public class KlijentiController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        public List<Klijenti_Result> GetKlijenti()
        {
            return dm.esp_Klijenti_SelectAll().OrderBy(x => x.KlijentID).ToList();
        }

        [HttpGet]
        [Route("api/Klijenti/{klijentID}")]
        public Klijenti GetKlijenti(string klijentID)
        {
            int kID = Convert.ToInt32(klijentID);
            return dm.Klijentis.Where(x => x.KlijentID == kID).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Klijenti/GetNeaktivniKlijenti/")]
        public List<Klijenti> GetNeaktivniKlijenti()
        {
            return dm.Klijentis.Where(x => x.Aktivan == false).ToList();
        }


        [ResponseType(typeof(Klijenti))]
        public IHttpActionResult PostKlijenti(Klijenti obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                dm.Klijentis.Add(obj);
                dm.SaveChanges();
            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return CreatedAtRoute("DefaultApi", new { id = obj.KlijentID }, obj);
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
        [Route("api/Klijenti/SearchByName/{name?}")]
        public List<Klijenti_Result> SearchByName(string name = "")
        {
            return dm.esp_Klijenti_SelectByImePrezime(name).ToList();
        }

        [HttpGet]
        [Route("api/Klijenti/SearchByBirthDate")]
        public List<Klijenti_Result> SearchByBirthDate()
        {
            return dm.esp_Klijenti_SelectByDatumRodjenja().ToList();
        }

        [ResponseType(typeof(Klijenti))]
        [Route("api/Klijenti/GetByUsername/{username}")]
        public IHttpActionResult GetByUsername(string username)
        {
            Klijenti klijenti = dm.esp_Klijenti_SelectByKorisnickoIme(username).FirstOrDefault();

            if (klijenti == null)
            {
                return NotFound();
            }

            return Ok(klijenti);
        }

        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/Klijenti/{id}")]
        public IHttpActionResult PutKlijenti(int id, Klijenti k)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != k.KlijentID)
                return BadRequest();

            dm.esp_Klijenti_Update(id, k.Ime, k.Prezime, k.DatumRodjenja, k.Adresa, k.Email, k.BrojTelefona, k.Napomena, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.TerminiCount, k.Aktivan);

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
