using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDlaPsow
{
    public class ClassVisits
    {
        public int idVisit { get; set; }
        public int idDog { get; set; }
        public string dogsName { get; set; }
        public string status {get; set;}
        public DateTime beginDate { get; set; }
        public DateTime endDate { get; set; }

        public ClassVisits() { }

    }
}
