using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class Frizeri_Result
    {
        public int FrizerID { get; set; }

        public string ImePrezime { get; set; }

        public string KorisnickoIme { get; set; }

        public byte[] ProfilnaSlika { get; set; }

        public byte[] SlikaThumb { get; set; }

        public string Opis { get; set; }

        public Nullable<decimal> UslugaOcjena { get; set; }

        public Nullable<decimal> TretmanOcjena { get; set; }

        public Nullable<decimal> ProsjecnaOcjena { get; set; }
    }
}
