using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalonSolution.Navigation
{

    public class NavigacijskiMeniMenuItem
    {
        public NavigacijskiMeniMenuItem()
        {
            TargetType = typeof(PregledFrizera);
        }
        public string ImageSource { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}