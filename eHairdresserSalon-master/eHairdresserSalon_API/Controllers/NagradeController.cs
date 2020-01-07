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
    public class NagradeController : ApiController
    {

        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [HttpGet]
        public List<Nagrade_Result> GetNagrade()
        {
            return dm.esp_Nagrade_SelectAll().OrderBy(x => x.NagradaID).ToList();
        }

        [HttpGet]
        [Route("api/Nagrade/{nagradaID}")]
        public Nagrade GetTermini(string nagradaID)
        {
            int nID = Convert.ToInt32(nagradaID);
            return dm.Nagrade.Where(x => x.NagradaID == nID).FirstOrDefault();
        }


        [HttpGet]
        [Route("api/Nagrade/SearchByName/{name?}")]
        public List<Nagrade_Result> SearchByName(string name = "")
        {
            return dm.esp_Nagrade_SelectByNaziv(name).ToList();
        }

        [ResponseType(typeof(void))]
        [Route("api/Nagrade/{id}")]
        public IHttpActionResult PutNagrade(int id, Nagrade n)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != n.NagradaID)
                return BadRequest();

            dm.esp_Nagrade_Update(id, n.Naziv, n.Od, n.Do);

            dm.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(Nagrade))]
        public IHttpActionResult PostNagrade(Nagrade obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Nagrade.Add(obj);
            dm.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = obj.NagradaID }, obj);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dm.Dispose();
            }

            base.Dispose(disposing);
        }
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}