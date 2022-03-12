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
    /// Logika interakcji dla klasy WindowDailyInfo.xaml
    /// </summary>
    public partial class WindowDailyInfo : Window
    {
        public WindowDailyInfo()
        {
            InitializeComponent();
        }

        ClassDataBase _base = new ClassDataBase();
        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            _base.OpenConection();
            _base.GetDailyInfoDate(TextboxName.Text, DatePickerDate.SelectedDate.Value);
            dataGridDogActive.ItemsSource = _base.collectionofActivities;
            _base.CloseConnection();
        }
    }
}
