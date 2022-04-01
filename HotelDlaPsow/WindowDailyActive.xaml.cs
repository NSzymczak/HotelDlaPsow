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
    public partial class WindowDailyActive : Window
    {
        public WindowDailyActive()
        {
            InitializeComponent();
        }

        ClassDataBase _base = new ClassDataBase();
        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {

            if (TextboxName.Text != null)
            {
                _base.OpenConection();
                LabelName.Content = _base.GetDogName(Convert.ToInt32(TextboxName.Text));
                _base.CloseConnection();
            }
            if (TextboxName.Text != null && DatePickerDate.SelectedDate != null)
            {
                _base.OpenConection();
                _base.GetDailyInfoDate(Convert.ToInt32(TextboxName.Text), DatePickerDate.SelectedDate.Value);
                dataGridActivity.ItemsSource = _base.collectionofActivities;
                _base.CloseConnection();
            }
                
            
        }
    }
}
