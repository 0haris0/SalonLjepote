using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class DodatniTretmani_Ocjene_Result
    {
        public int TretmanID { get; set; }

        public string NazivTretmana { get; set; }

        public string Opis { get; set; }

        public int Cijena { get; set; }

        public Nullable<decimal> ProsjecnaOcjenaDec { get; set; }

        public string ProsjecnaOcjena { get; set; }

        public int VrstaUslugeID { get; set; }
    }
}
