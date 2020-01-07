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
    public class SkladisteController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        [Route("api/Skladiste/SearchByName/{name?}")]
        public List<Skladiste_Result> SearchByName(string name = "")
        {
            return dm.esp_Skladiste_GetSkladistaAll(name).ToList();
        }


        [HttpGet]
        [Route("api/Skladiste/{skaldisteId}")]
        public Skladiste GetSkladiste(string skaldisteId)
        {
            int uID = Convert.ToInt32(skaldisteId);
            return dm.Skladiste.Where(x => x.SkladisteID == uID).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Skladiste/GetSkladisteByTretman/{tretmanID}")]
        public Skladiste GetSkladisteByTretman(string tretmanID)
        {
            int tID = Convert.ToInt32(tretmanID);
            return dm.Skladiste.Where(x => x.TretmanID == tID).FirstOrDefault();
        }

        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/Skladiste/{id}")]
        public IHttpActionResult PutSkladiste(int id, Skladiste s)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != s.SkladisteID)
                return BadRequest();

            
            dm.esp_Skladiste_Update(id, s.TretmanID,s.Kolicina);

            return StatusCode(HttpStatusCode.NoContent);
        }


        [ResponseType(typeof(Skladiste))]
        public IHttpActionResult PostSkladiste(Skladiste obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dm.Skladiste.Add(obj);

            dm.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = obj.SkladisteID }, obj);
        }
    }
}
