using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDO002ONL019_DennyTandiono_Assignment3.Models
{
    public class MovieItem
    {
        public int id { get; set; }
        public string movieName{ get; set; }
        public string genre { get; set; }
        public string duration { get; set; }
        public Nullable<DateTime> releaseDate { get; set; }
    }
}
