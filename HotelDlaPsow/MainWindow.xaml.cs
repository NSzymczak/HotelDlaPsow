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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelDlaPsow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int loginFailed = 0;
        private int loginLeft = 3;
        private MessageBoxResult result;

        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu menu = new WindowMenu();
                if (TextBoxLogin.Text == "a")
                {
                    if (PasswordBoxPass.Password == "a")
                    {
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        loginLeft--;
                        MessageBox.Show("Niepoprawne hasło! Pozostało " + loginLeft + " prób logowania.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                        loginFailed++;
                    }
                }
                else
                {
                    loginLeft--;
                    MessageBox.Show("Niepoprawny login! Pozostało " + loginLeft + " prób logowania.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    loginFailed++;
                }
            if (loginFailed >= 3)
            {
               result = MessageBox.Show("Konto zostało zablokowane!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                switch (result) {
                    case MessageBoxResult.OK:
                        Environment.Exit(loginFailed);
                    break;
                }
            }
        }

        private void HandleHandleInput (object sender, TextCompositionEventArgs e) {
           
                e.Handled = true;
            
        }
    }
}
