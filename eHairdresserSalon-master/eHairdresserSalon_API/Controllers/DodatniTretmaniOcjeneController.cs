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
    public class DodatniTretmaniOcjeneController : ApiController
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        [ResponseType(typeof(DodatniTretmaniOcjene))]
        public IHttpActionResult PostDodatniTretmaniOcjene(DodatniTretmaniOcjene obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            dm.DodatniTretmaniOcjene.Add(obj);
            dm.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = obj.TretmanOcjenaID }, obj);
        }
    }
}
