using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class Takmicenja_Result
    {
        public int TakmicenjeID { get; set; }

        public string Naziv { get; set; }

        public System.DateTime Datum { get; set; }

        public string Mjesto { get; set; }

        public string Opis { get; set; }

        public string FrizerImePrezime { get; set; }
    }
}
