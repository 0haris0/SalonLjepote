using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class Termini
    {
        public int TerminID { get; set; }

        public System.DateTime Datum { get; set; }

        public System.TimeSpan Vrijeme { get; set; }

        public Nullable<int> KlijentID { get; set; }

        public Nullable<int> FrizerID { get; set; }

        public Nullable<int> UslugaID { get; set; }

        public Nullable<bool> Zauzeto { get; set; }

        public Nullable<int> TretmanID { get; set; }

        public Nullable<bool> OcijenjenaUsluga { get; set; }

        public Nullable<bool> OcijenjenTretman { get; set; }
    }
}
