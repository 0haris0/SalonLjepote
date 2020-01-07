using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eHairdresserSalon_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebBeautySalon.Util;

namespace WebBeautySalon.Controllers
{
    public class UslugeController : Controller
    {
        private WebAPIHelper uslugeService = new WebAPIHelper(Global.APIAddress, "api/Usluge");
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper(Global.APIAddress, "api/VrsteUsluga");

        List<Usluge_Result> usluge = new List<Usluge_Result>();
        List<VrsteUsluga> vrste = new List<VrsteUsluga>();


        public IActionResult Index(int vrstaId = 1)
        {
            HttpResponseMessage responseUsluge = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaId.ToString());
            if (responseUsluge.IsSuccessStatusCode)
            {
                usluge.Clear();
                usluge = responseUsluge.Content.ReadAsAsync<List<Usluge_Result>>().Result;
            }
            
            HttpResponseMessage responseVrste = vrsteUslugaService.GetResponse();
            if (responseVrste.IsSuccessStatusCode)
            {
                vrste = responseVrste.Content.ReadAsAsync<List<VrsteUsluga>>().Result;
            }

            ViewData["vrste"] = vrste;
            ViewData["odabranaVrsta"] = vrstaId;
            return View(usluge);
        }

        //public IActionResult Dodaj()
        //{
        //    Usluge u = new Usluge();
        //    ViewData["kljuc1"] = u;
        //    return View("Edit");
        //}

        public IActionResult Edit(string id)
        {
            HttpResponseMessage responseUsluge = uslugeService.GetResponse(id);
            if (responseUsluge.IsSuccessStatusCode)
            {
                usluge.Clear();
                usluge = responseUsluge.Content.ReadAsAsync<List<Usluge_Result>>().Result;
            }

            var usl = usluge.Where(x => x.UslugaID == int.Parse(id)).FirstOrDefault();


            return View(usl);
        }

        [HttpPost]
        public IActionResult Edits(Usluge u)
        {
            var uid = u.UslugaID;
            var nu=u.NazivUsluge;
            var tm = u.TrajanjeMinute;
            var cu = u.CijenaUsluge;

            //if (vrstaUslugeComboBox.SelectedIndex != 0)
            //    u.VrstaUslugeID = Convert.ToInt32(vrstaUslugeComboBox.SelectedValue);
            var vuid = u.VrstaUslugeID;

            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public IActionResult Doda()
        //{
        //    Usluge u = new Usluge();
        //    u.NazivUsluge = NazivUslugeInput.Text;
        //    u.TrajanjeMinute = Convert.ToInt32(TrajanjeUslugeInput.Text);
        //    u.CijenaUsluge = Convert.ToDecimal(CijenaUslugeInput.Text);

        //    if (vrstaUslugeComboBox.SelectedIndex != 0)
        //        u.VrstaUslugeID = Convert.ToInt32(vrstaUslugeComboBox.SelectedValue);

        //    HttpResponseMessage response = uslugeService.PostResponse(u);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        MessageBox.Show("Usluga je uspjesno dodana.");
        //        DialogResult = DialogResult.OK;
        //        Close();
        //    }
        //    else
        //    {
        //        string msg = response.ReasonPhrase;
        //        if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
        //            msg = Messages.ResourceManager.GetString(response.ReasonPhrase);

        //        MessageBox.Show("Error code: " + response.StatusCode + " Message: " + msg);

        //    }

        //    vm.VrsteProizvoda = GetVrsteProizvodaAll();
        //    vm.Proizvodi = GetProizvodiAll();
        //    vm.Auta = GetAutaAll();
        //    vm.VrstaProizvodaID = vm.VrstaProizvodaID;
        //    ViewData["vrste"] = Global.vrste;
        //    return View(vm);
        //}


        //public IActionResult Snimi(int uslugaID, string NazivUsluge, int TrajanjeMinute, decimal CijenaUsluge, int VrstaUslugeID)
        //{
        //    Usluge u;
        //    if (uslugaID != 0)
        //    {
        //        u = _db._studenti.Find(studentid);
        //    }
        //    else
        //    {
        //        s = new Student();
        //        _db._studenti.Add(s);
        //    }

        //    s.Ime = ime;
        //    s.OpstinaId = opstinaId;
        //    s.Prezime = prezime;
        //    _db.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        //public IActionResult Obrisi(int id)
        //{
        //    Student p1 = _db._studenti.Where(x => x.Id == id).FirstOrDefault();
        //    _db._studenti.Remove(p1);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}