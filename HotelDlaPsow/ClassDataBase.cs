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
        public ObservableCollection<ClassVisits> collectionofVisits = new ObservableCollection<ClassVisits>();


        private SqlConnection cnn;
        public void OpenConection()
        {
            string connetionString;
            try
            {
                connetionString = @"Data Source=DESKTOP-NGM307V;Initial Catalog=Hotel;Integrated Security=True;";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }
            catch
            {
                try
                {
                    connetionString = @"Data Source=KAMIL;Initial Catalog=Hotel;Integrated Security=True;";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                }
                catch { }
            }
        }

        public void CloseConnection()
        {
            cnn.Close();
        }


        //_______________DOG____________________
        public void GetDogs()                                 //Wczytaj psiaki 
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
                dog.sterilization = (int)row["sterilization"];
                dog.breed = (string)row["breed"];
                dog.color = (string)row["color"];
                dog.age = (double)row["age"];
                dog.weight = (double)row["weight"];
                dog.food = (string)row["food"];
                dog.feedingFrequency = (int)row["feedingFrequency"];
                dog.feedingHour = (string)row["feedingHour"];
                dog.feedingNotes = (string)row["feedingNotes"];
                dog.hoursOfWalks = (string)row["hoursOfWalks"];
                dog.lengthOfWalks = (int)row["lengthOfWalks"];
                dog.healthStatus = (string)row["healthStatus"];
                dog.veterinarianIndication = (string)row["veterinarianIndication"];
                dog.vaccination = (DateTime)row["Vaccination"];
                dog.ticksProtection = (DateTime)row["ticksProtection"];
                dog.vetInfo = (string)row["vetInfo"];
                dog.characterDescription = (string)row["characterDescription"];
                dog.catsReaction = (string)row["CatsReaction"];
                dog.favToy = (string)row["favToy"];
                dog.knownCommands = (string)row["knownCommands"];
                dog.beautyTreatments = (string)row["beautyTreatments"];
                dog.hotelStays = (string)row["hotelStays"];
                collectionofDogs.Add(dog);
            }
        }

        public void AddDateDog(ClassDogs classDogs)           //Dodaj psiaka   
        {
            OpenConection();
                SqlCommand command = new SqlCommand("addDateDog", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idDog", SqlDbType.Int).Value = classDogs.idDog;
                command.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = classDogs.name;
                command.Parameters.AddWithValue("@sterilization", SqlDbType.NVarChar).Value = classDogs.sterilization;
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
                command.Parameters.AddWithValue("@Vaccination", SqlDbType.DateTime).Value = classDogs.vaccination;
                command.Parameters.AddWithValue("@ticksProtection", SqlDbType.DateTime).Value = classDogs.ticksProtection;
                command.Parameters.AddWithValue("@vetInfo", SqlDbType.NVarChar).Value = classDogs.vetInfo;
                command.Parameters.AddWithValue("@characterDescription", SqlDbType.NVarChar).Value = classDogs.characterDescription;
                command.Parameters.AddWithValue("@CatsReaction", SqlDbType.NVarChar).Value = classDogs.catsReaction;
                command.Parameters.AddWithValue("@favToy", SqlDbType.NVarChar).Value = classDogs.favToy;
                command.Parameters.AddWithValue("@knownCommands", SqlDbType.NVarChar).Value = classDogs.knownCommands;
                command.Parameters.AddWithValue("@beautyTreatments", SqlDbType.NVarChar).Value = classDogs.beautyTreatments;
                command.Parameters.AddWithValue("@hotelStays", SqlDbType.NVarChar).Value = classDogs.hotelStays;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
        }

        public void DeletleDateDog(int id_deletle)            //Usuń psiaka    
        {
            SqlCommand cmd = new SqlCommand("deleteDog", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id_deletle;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public void EditDateDog(ClassDogs classDogs)          //Edytuj psiaka  
        {
            SqlCommand command = new SqlCommand("editDateDog", cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idDog", SqlDbType.Int).Value = classDogs.idDog;
            command.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = classDogs.name;
            command.Parameters.AddWithValue("@sterilization", SqlDbType.NVarChar).Value = classDogs.sterilization;
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
            command.Parameters.AddWithValue("@Vaccination", SqlDbType.DateTime).Value = classDogs.vaccination;
            command.Parameters.AddWithValue("@ticksProtection", SqlDbType.DateTime).Value = classDogs.ticksProtection;
            command.Parameters.AddWithValue("@vetInfo", SqlDbType.NVarChar).Value = classDogs.vetInfo;
            command.Parameters.AddWithValue("@characterDescription", SqlDbType.NVarChar).Value = classDogs.characterDescription;
            command.Parameters.AddWithValue("@CatsReaction", SqlDbType.NVarChar).Value = classDogs.catsReaction;
            command.Parameters.AddWithValue("@favToy", SqlDbType.NVarChar).Value = classDogs.favToy;
            command.Parameters.AddWithValue("@knownCommands", SqlDbType.NVarChar).Value = classDogs.knownCommands;
            command.Parameters.AddWithValue("@beautyTreatments", SqlDbType.NVarChar).Value = classDogs.beautyTreatments;
            command.Parameters.AddWithValue("@hotelStays", SqlDbType.NVarChar).Value = classDogs.hotelStays;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }


        //_______________DAILYINFO____________________
        public void GetDailyInfoDate(int idDog, DateTime date)                //Wczytaj dzienne informacje  
        {
            OpenConection();
            collectionofActivities.Clear();
            SqlCommand command = new SqlCommand("getDailyInfo", cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idDog", SqlDbType.Int).Value = idDog;
            command.Parameters.AddWithValue("@date", SqlDbType.Date).Value = date;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ClassDailyActive dailyActive = new ClassDailyActive();

                dailyActive.idActivity = (int)(row["idActivity"]);
                dailyActive.hourActivity = (TimeSpan)(row["hourActivity"]);
                dailyActive.activityDescription = (string)row["activityDescription"];
                collectionofActivities.Add(dailyActive);
            }
        }

        public string GetDogName(int idDog)                                   //Sprawdź imie pieska         
        {
            OpenConection();
            collectionofActivities.Clear();
            SqlCommand command = new SqlCommand("getDogName", cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idDog", SqlDbType.Int).Value = idDog;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                return (string)row["name"];
            }
            return " ";
        }

        public void AddDailyInfoDate(ClassDailyActive classDailyActive)       //Dodaj aktywność pieska      
        {
            OpenConection();
            SqlCommand command = new SqlCommand("addDailyActive", cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idActivity", SqlDbType.Int).Value = classDailyActive.idActivity;
            command.Parameters.AddWithValue("@idDog", SqlDbType.Int).Value = classDailyActive.idDog;
            command.Parameters.AddWithValue("@dogName", SqlDbType.NVarChar).Value = classDailyActive.dogName;
            command.Parameters.AddWithValue("@hourActivity", SqlDbType.NVarChar).Value = classDailyActive.hourActivity;
            command.Parameters.AddWithValue("@dateActivity", SqlDbType.NVarChar).Value = classDailyActive.dateActivity;
            command.Parameters.AddWithValue("@activityDescription", SqlDbType.NVarChar).Value = classDailyActive.activityDescription;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public void DeletleDailyInfoDate(int idDeletle)                       //Usuń aktywność pieska       
        {

            SqlCommand cmd = new SqlCommand("deleteDailyInfoDate", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = idDeletle;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    
        public void EditDailyInfoDate(ClassDailyActive classDailyActive)
        {

        }


        //_______________Wizyty______________________
        public void GetVisits()
        {
            SqlCommand command = new SqlCommand("getVisits", cnn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ClassVisits visits = new ClassVisits();
                visits.idVisit = (int)(row["idVisit"]);
                visits.dogsName = (string)(row["name"]);
                visits.beginDate = (DateTime)row["beginDate"];
                visits.endDate = (DateTime)row["endDate"];
                collectionofVisits.Add(visits);
            }
        }
        public void AddVisits() { }

        public void DeleteVisit() { }

        public void EditVisit() { }
    }
}
