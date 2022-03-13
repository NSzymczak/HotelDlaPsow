using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelDlaPsow
{
    /// <summary>
    /// Logika interakcji dla klasy WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
        }

        private void ButtonDailyActive_Click(object sender, RoutedEventArgs e)
        {
            WindowDailyActive win = new WindowDailyActive();
            win.Show();
        }

        private void ButtonDogList_Click(object sender, RoutedEventArgs e)
        {
            WindowDogList win   = new WindowDogList();  
            win.Show();
        }

        private void ButtonVisit_Click(object sender, RoutedEventArgs e)
        {
            WindowVisits windowVisits = new WindowVisits();
            windowVisits.Show();
        }
    }
}
