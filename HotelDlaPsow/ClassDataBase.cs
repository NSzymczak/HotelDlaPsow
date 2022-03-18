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
        public ObservableCollection<ClassDogs> collectionofDogs = new ObservableCollection<ClassDogs>();


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

        public void CloseConnection()
        {
            cnn.Close();
        }


        //_______________DOG____________________
        public void GetDogs()
        {
            SqlCommand command = new SqlCommand("getDogInfo", cnn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ClassDogs dog = new ClassDogs();
                dog.idDog = (int)(row["idDog"]);
                dog.name = (string)(row["name"]);
                dog.sterilization = (bool)row["sterilization"];
                dog.lastEstrus = (DateTime)row["lastEstrus"];
                dog.breed = (string)row["breed"];
                dog.color = (string)row["color"];
                dog.age = (int)row["age"];
                dog.weight = (int)row["weight"];
                dog.food = (string)row["food"];
                dog.feedingFrequency = (int)row["feedingFrequency"];
                dog.feedingHour = (string)row["feedingHour"];
                dog.feedingNotes = (string)row["feedingNotes"];
                dog.hoursOfWalks = (string)row["hoursOfWalks"];
                dog.lengthOfWalks = (int)row["lengthOfWalks"];
                dog.healthStatus = (string)row["healthStatus"];
                dog.veterinarianIndication = (string)row["veterinarianIndication"];
                dog.Vaccination = (DateTime)row["Vaccination"];
                dog.ticksProtection = (DateTime)row["ticksProtection"];
                dog.vetInfo = (string)row["vetInfo"];
                dog.characterDescription = (string)row["characterDescription"];
                dog.CatsReaction = (string)row["CatsReaction"];
                dog.favToy = (string)row["favToy"];
                dog.knownCommands = (string)row["knownCommands"];
                dog.beautyTreatments = (string)row["beautyTreatments"];
                dog.hotelStays = (string)row["hotelStays"];
            }
        }

        public void AddDateDog(ClassDogs classDogs)
        {
            try
            {;
                SqlCommand command = new SqlCommand("AddDateDog", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idDog", SqlDbType.Int).Value = classDogs.idDog;
                command.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = classDogs.name;
                command.Parameters.AddWithValue("@sterilization", SqlDbType.NVarChar).Value = classDogs.sterilization;
                command.Parameters.AddWithValue("@lastEstrus", SqlDbType.DateTime).Value = classDogs.lastEstrus;
                command.Parameters.AddWithValue("@breed", SqlDbType.NVarChar).Value = classDogs.breed;
                command.Parameters.AddWithValue("@color", SqlDbType.NVarChar).Value = classDogs.color;
                command.Parameters.AddWithValue("@age", SqlDbType.Int).Value = classDogs.age;
                command.Parameters.AddWithValue("@weight", SqlDbType.Int).Value = classDogs.weight;
                command.Parameters.AddWithValue("@food", SqlDbType.NVarChar).Value = classDogs.food;
                command.Parameters.AddWithValue("@feedingFrequency", SqlDbType.Int).Value = classDogs.feedingFrequency;
                command.Parameters.AddWithValue("@feedingHour", SqlDbType.NVarChar).Value = classDogs.feedingHour;
                command.Parameters.AddWithValue("@feedingNotes", SqlDbType.NVarChar).Value = classDogs.feedingNotes;
                command.Parameters.AddWithValue("@hoursOfWalks", SqlDbType.NVarChar).Value = classDogs.hoursOfWalks;
                command.Parameters.AddWithValue("@lengthOfWalks", SqlDbType.NVarChar).Value = classDogs.lengthOfWalks;
                command.Parameters.AddWithValue("@healthStatus", SqlDbType.NVarChar).Value = classDogs.healthStatus;
                command.Parameters.AddWithValue("@veterinarianIndication", SqlDbType.NVarChar).Value = classDogs.veterinarianIndication;
                command.Parameters.AddWithValue("@Vaccination", SqlDbType.DateTime).Value = classDogs.Vaccination;
                command.Parameters.AddWithValue("@ticksProtection", SqlDbType.DateTime).Value = classDogs.ticksProtection;
                command.Parameters.AddWithValue("@vetInfo", SqlDbType.NVarChar).Value = classDogs.vetInfo;
                command.Parameters.AddWithValue("@characterDescription", SqlDbType.NVarChar).Value = classDogs.characterDescription;
                command.Parameters.AddWithValue("@CatsReaction", SqlDbType.NVarChar).Value = classDogs.CatsReaction;
                command.Parameters.AddWithValue("@favToy", SqlDbType.NVarChar).Value = classDogs.favToy;
                command.Parameters.AddWithValue("@knownCommands", SqlDbType.NVarChar).Value = classDogs.knownCommands;
                command.Parameters.AddWithValue("@beautyTreatments", SqlDbType.NVarChar).Value = classDogs.beautyTreatments;
                command.Parameters.AddWithValue("@hotelStays", SqlDbType.NVarChar).Value = classDogs.hotelStays;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
            catch
            {

            }
        }

        public void DeletleDateDog(int id_deletle)
        {
            SqlCommand cmd = new SqlCommand("deleteDog", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id_deletle;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public void EditDateDog(ClassDogs classDogs)
        {
            SqlCommand command = new SqlCommand("EditDateDog", cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idDog", SqlDbType.Int).Value = classDogs.idDog;
            command.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = classDogs.name;
            command.Parameters.AddWithValue("@sterilization", SqlDbType.NVarChar).Value = classDogs.sterilization;
            command.Parameters.AddWithValue("@lastEstrus", SqlDbType.DateTime).Value = classDogs.lastEstrus;
            command.Parameters.AddWithValue("@breed", SqlDbType.NVarChar).Value = classDogs.breed;
            command.Parameters.AddWithValue("@color", SqlDbType.NVarChar).Value = classDogs.color;
            command.Parameters.AddWithValue("@age", SqlDbType.Int).Value = classDogs.age;
            command.Parameters.AddWithValue("@weight", SqlDbType.Int).Value = classDogs.weight;
            command.Parameters.AddWithValue("@food", SqlDbType.NVarChar).Value = classDogs.food;
            command.Parameters.AddWithValue("@feedingFrequency", SqlDbType.Int).Value = classDogs.feedingFrequency;
            command.Parameters.AddWithValue("@feedingHour", SqlDbType.NVarChar).Value = classDogs.feedingHour;
            command.Parameters.AddWithValue("@feedingNotes", SqlDbType.NVarChar).Value = classDogs.feedingNotes;
            command.Parameters.AddWithValue("@hoursOfWalks", SqlDbType.NVarChar).Value = classDogs.hoursOfWalks;
            command.Parameters.AddWithValue("@lengthOfWalks", SqlDbType.NVarChar).Value = classDogs.lengthOfWalks;
            command.Parameters.AddWithValue("@healthStatus", SqlDbType.NVarChar).Value = classDogs.healthStatus;
            command.Parameters.AddWithValue("@veterinarianIndication", SqlDbType.NVarChar).Value = classDogs.veterinarianIndication;
            command.Parameters.AddWithValue("@Vaccination", SqlDbType.DateTime).Value = classDogs.Vaccination;
            command.Parameters.AddWithValue("@ticksProtection", SqlDbType.DateTime).Value = classDogs.ticksProtection;
            command.Parameters.AddWithValue("@vetInfo", SqlDbType.NVarChar).Value = classDogs.vetInfo;
            command.Parameters.AddWithValue("@characterDescription", SqlDbType.NVarChar).Value = classDogs.characterDescription;
            command.Parameters.AddWithValue("@CatsReaction", SqlDbType.NVarChar).Value = classDogs.CatsReaction;
            command.Parameters.AddWithValue("@favToy", SqlDbType.NVarChar).Value = classDogs.favToy;
            command.Parameters.AddWithValue("@knownCommands", SqlDbType.NVarChar).Value = classDogs.knownCommands;
            command.Parameters.AddWithValue("@beautyTreatments", SqlDbType.NVarChar).Value = classDogs.beautyTreatments;
            command.Parameters.AddWithValue("@hotelStays", SqlDbType.NVarChar).Value = classDogs.hotelStays;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }


        //_______________DAILYINFO____________________
        public void GetDailyInfoDate(string Name, DateTime date)
        {
            collectionofActivities.Clear();
            SqlCommand command = new SqlCommand("getDailyInfoDate", cnn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ClassDailyActive dailyActive = new ClassDailyActive();

                dailyActive.idActivity = (int)(row["id_plant"]);
                dailyActive.dogName = (string)row["dogName"];
                dailyActive.dateActivity = (DateTime)(row["dateActivity"]);
                dailyActive.hourActivity = (DateTime)(row["hourActivity"]);
                dailyActive.activityDescription = (string)row["Description"];
            }
        }

    }
}
