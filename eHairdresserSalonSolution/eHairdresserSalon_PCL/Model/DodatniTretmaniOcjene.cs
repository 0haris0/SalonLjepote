using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class DodatniTretmaniOcjene
    {
        public int TretmanOcjenaID { get; set; }

        public int KlijentID { get; set; }

        public int TretmanID { get; set; }

        public int Ocjena { get; set; }

        public int FrizerID { get; set; }
    }
}
