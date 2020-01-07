using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class KlijentiTakmicenja
    {
        public int KlijentID { get; set; }

        public int TakmicenjeID { get; set; }

        public Nullable<System.DateTime> DatumPrijave { get; set; }
    }
}
