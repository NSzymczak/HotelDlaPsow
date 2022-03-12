using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace HotelDlaPsow
{
    public class ClassDataBase
    {
        public ObservableCollection<ClassDailyActive> collectionofActivities = new ObservableCollection<ClassDailyActive>();


        private SqlConnection cnn;
        public void OpenConection()
        {
            string connetionString;
            try
            {
                connetionString = @"Data Source=";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }
            catch 
            {
                MessageBox.Show("Błąd połączenia z bazą");
            }
        }

        public void GetDailyInfoDate(string Name, DateTime date)
        {

        }
        public void CloseConnection()
        {
            cnn.Close();
        }
    }
}
