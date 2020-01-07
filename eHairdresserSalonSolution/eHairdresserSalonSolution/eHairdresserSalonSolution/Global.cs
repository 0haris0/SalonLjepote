using eHairdresserSalon_PCL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHairdresserSalonSolution
{
    public class Global
    {
        public static Klijenti prijavljeniKlijent { get; set; }

        public static string APIAddress { get; set; }

        #region API Routes

        public const string klijentiRoute = "api/Klijenti";
        public const string frizeriRoute = "api/Frizeri";
        public const string DodatniTretmaniRoute = "api/DodatniTretmani";
        public const string TakmicenjaRoute = "api/Takmicenja";
        public const string TerminiRoute = "api/Termini";
        public const string UslugeRoute = "api/Usluge";
        public const string SkladisteRoute = "api/Skladiste";
        public const string UslugeOcjeneRoute = "api/UslugeOcjene";
        public const string DodatniTretmaniOcjeneRoute = "api/DodatniTretmaniOcjene";
        public const string KlijentiTakmicenjaRoute = "api/KlijentiTakmicenja";
        public const string VrsteUslugaRoute = "api/VrsteUsluga";

        #endregion
    }
}
