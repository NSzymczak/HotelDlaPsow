using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HotelDlaPsow
{
    public class ClassDailyActive
    {
        public int idActivity { get; set; }
        public string dogName { get; set; }
        public DateTime dateActivity { get; set; }
        public DateTime hourActivity { get; set; }
        public string activityDescription { get; set; }

        public ClassDailyActive(string dogName,DateTime dateActivity, DateTime hourActivity, string activityDescription)
        {
            this.dogName = dogName; 
            this.dateActivity = dateActivity;
            this.hourActivity = hourActivity;
            this.activityDescription = activityDescription;
        }

        public ClassDailyActive() { }

    }
}
