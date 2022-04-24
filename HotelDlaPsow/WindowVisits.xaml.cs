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
    /// Logika interakcji dla klasy WindowVisits.xaml
    /// </summary>
    public partial class WindowVisits : Window
    {
        ClassDataBase _base = new ClassDataBase();
        public WindowVisits()
        {
            InitializeComponent();
            _base.OpenConection();
            _base.GetVisits();
            dataGridVisits.ItemsSource = _base.collectionofVisits;
            _base.CloseConnection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassVisits visits = new ClassVisits();
            visits.beginDate=DateTime.Now;
            visits.endDate = DateTime.Now;
            WindowVisitsAdd visitsAdd = new WindowVisitsAdd(visits);
            visitsAdd.DataContext = visits;
            visitsAdd.ShowDialog();
            _base.AddVisits(visits);
            dataGridVisits.Items.Clear();
            _base.GetVisits();
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridVisits.SelectedItem != null)
            {
                ClassVisits visits = new ClassVisits();
                visits.beginDate = DateTime.Now;
                visits.endDate = DateTime.Now;
                WindowVisitsAdd visitsAdd = new WindowVisitsAdd(visits);
                visitsAdd.DataContext = visits;
                visitsAdd.ShowDialog();
                if (visitsAdd.IsOkPressed)
                {
                    int index = _base.collectionofVisits.IndexOf((ClassVisits)dataGridVisits.SelectedItem);
                    _base.collectionofVisits[index] = visits;
                    _base.EditVisit(visits);
                    dataGridVisits.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano obiektu");
            }

        }

        private void buttonDeletele_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
