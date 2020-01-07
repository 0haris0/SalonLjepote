using eHairdresserSalon_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_UI
{
    public class Global
    {
        public static Klijenti prijavljeniKlijent { get; set; }

        public static Frizeri prijavljeniFrizer { get; set; }


        #region API Routes

        public const string KlijentiRoute = "api/Klijenti";

        public const string FrizeriRoute = "api/Frizeri";

        #endregion
    }
}
