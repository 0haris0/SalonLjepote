using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class UslugeOcjene
    {
        public int UslugaOcjenaID { get; set; }

        public int KlijentID { get; set; }

        public int UslugaID { get; set; }

        public int FrizerID { get; set; }

        public int Ocjena { get; set; }

        public Nullable<int> TerminID { get; set; }
    }
}
