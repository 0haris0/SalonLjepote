using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eHairdresserSalon_API.Models;
using Microsoft.AspNetCore.Mvc;
using WebBeautySalon.Models;
using WebBeautySalon.Util;

namespace WebBeautySalon.Controllers
{
    public class HomeController : Controller
    {
        private WebAPIHelper akcijaProizvodiService = new WebAPIHelper(Global.APIAddress, "api/Takmicenja");

        List<Takmicenja_Result> tak = new List<Takmicenja_Result>();

        public IActionResult Index()
        {

            HttpResponseMessage responseAkcije = akcijaProizvodiService.GetResponse();
            if (responseAkcije.IsSuccessStatusCode)
            {
                tak = responseAkcije.Content.ReadAsAsync<List<Takmicenja_Result>>().Result;
            }

            ViewData["datas"] = tak;


            return View(tak);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
