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
    /// Logika interakcji dla klasy WindowDogAdd.xaml
    /// </summary>
    public partial class WindowDogAdd : Window
    {
        public bool IsOkPressed { get; set; }
        public WindowDogAdd(ClassDogs classDogs)
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            IsOkPressed = true;
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsOkPressed = false;
            this.Close();
        }

    }
}
