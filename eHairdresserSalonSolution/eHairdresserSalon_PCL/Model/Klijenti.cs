using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Model
{
    public class Klijenti
    {

        public int KlijentID { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public Nullable<System.DateTime> DatumRodjenja { get; set; }

        public string Adresa { get; set; }

        public string Email { get; set; }

        public string BrojTelefona { get; set; }

        public string Napomena { get; set; }

        public string KorisnickoIme { get; set; }

        public string LozinkaSalt { get; set; }

        public string LozinkaHash { get; set; }

        public Nullable<int> TerminiCount { get; set; }

        public Nullable<bool> Aktivan { get; set; }
    }
}
