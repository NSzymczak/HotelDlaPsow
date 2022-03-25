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
        public int idDog { get; set; }
        public string dogName { get; set; }
        public DateTime dateActivity { get; set; }
        public TimeSpan hourActivity { get; set; }
        public string activityDescription { get; set; }

        public ClassDailyActive(string dogName,DateTime dateActivity, TimeSpan hourActivity, string activityDescription)
        {
            this.idActivity = idActivity;
            this.idDog = idDog;
            this.dogName = dogName; 
            this.dateActivity = dateActivity;
            this.hourActivity = hourActivity;
            this.activityDescription = activityDescription;
        }

        public ClassDailyActive() { }

    }
}
