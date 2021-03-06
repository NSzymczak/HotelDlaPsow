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
    /// Logika interakcji dla klasy WindowDogList.xaml
    /// </summary>
    public partial class WindowDogList : Window
    {
        ClassDataBase _base =new ClassDataBase();
        public WindowDogList()
        {
            InitializeComponent();
            _base.OpenConection();
            _base.GetDogs();
            dataGridDogList.ItemsSource = _base.collectionofDogs;
            _base.CloseConnection();
        } 

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClassDogs _dogs = new ClassDogs();
                WindowDogAdd dogAdd = new WindowDogAdd(_dogs);
                dogAdd.DataContext = _dogs;
                dogAdd.ShowDialog();
                _base.collectionofDogs.Add(_dogs);
                _base.AddDateDog(_dogs);
                dataGridDogList.Items.Refresh();
            }
            catch { }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridDogList.SelectedItem != null)
            {
                ClassDogs _dogs = new ClassDogs((ClassDogs)dataGridDogList.SelectedItem);
                WindowDogAdd adddogs = new WindowDogAdd(_dogs);
                adddogs.DataContext = _dogs;
                adddogs.ShowDialog();
                if (adddogs.IsOkPressed)
                {
                    int index = _base.collectionofDogs.IndexOf((ClassDogs)dataGridDogList.SelectedItem);
                    _base.collectionofDogs[index] = _dogs;
                    _base.EditDateDog(_dogs);
                    dataGridDogList.Items.Refresh();
                }
            }
            else
                MessageBox.Show("Nie wybrano obiektu");
        }
    }
}
