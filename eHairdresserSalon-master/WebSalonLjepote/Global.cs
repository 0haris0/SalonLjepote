using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSalonLjepote
{
    public class Global
    {

        //public static List<VrsteProizvoda> vrste = new List<VrsteProizvoda>();

        //public static bool pregledaneObavijesti = false;

        public static string APIAddress = "http://ndemirovic.app.fit.ba/";


        #region API Routes

        public const string dodatniTretmaniRoute = "api/DodatniTretmani";
        public const string dodatniTretmaniOcjeneRoute = "api/DodatniTretmaniOcjene";
        public const string frizeriRoute = "api/Frizeri";

        //public const string proizvodiRoute = "api/proizvodi";
        //public const string ulogeRoute = "api/uloge";
        //public const string korisniciUlogeRoute = "api/korisniciUloge";
        //public const string upitiRoute = "api/upiti";
        //public const string odgovoriRoute = "api/Odgovori";
        //public const string ocjeneRoute = "api/ocjene";
        //public const string notifikacijeRoute = "api/notifikacije";
        //public const string autaRoute = "api/auta";
        //public const string akcijaProizvodiRoute = "api/akcijaProizvodi";

        #endregion
    }
}