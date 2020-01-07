using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class Termini_Result3
    {
        public int TerminID { get; set; }

        public System.DateTime Datum { get; set; }

        public System.TimeSpan Vrijeme { get; set; }

        public string KlijentImePrezime { get; set; }

        public string FrizerImePrezime { get; set; }

        public string NazivUsluge { get; set; }

        public Nullable<bool> Zauzeto { get; set; }

        public string NazivTretmana { get; set; }

        public Nullable<bool> OcijenjenaUsluga { get; set; }

        public Nullable<bool> OcijenjenTretman { get; set; }

        public string VrijemeDoTermina { get; set; }

        public string Ocjena { get; set; }

        public Nullable<bool> Ocijenjeno { get; set; }
    }
}
