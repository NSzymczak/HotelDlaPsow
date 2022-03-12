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
        int dogName;
        DateTime dateActivity;
        DateTime hourActivity;
        string activityDescription;

        ClassDailyActive(int dogName,DateTime dateActivity, DateTime hourActivity, string activityDescription)
        {
            this.dogName = dogName; 
            this.dateActivity = dateActivity;
            this.hourActivity = hourActivity;
            this.activityDescription = activityDescription;
        }

    }
}
