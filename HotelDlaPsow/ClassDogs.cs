using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDlaPsow
{
    public class ClassDogs
    {
        public int idDog { get; set; }                     //id
        public string name { get; set; }                   //imie
        public bool sterilization { get; set; }            //sterylizacja
        public DateTime lastEstrus { get; set; }           //ostatnia cieczka
        public string breed { get; set; }                  //rasa
        public string color { get; set; }                  //umaszczenie
        public float age { get; set; }                     //wiek
        public float weight { get; set; }                  //waga
        public string food { get; set; }                   //karma
        public int feedingFrequency { get; set; }          //czestotliwość karmienia
        public string feedingHour { get; set; }            //godziny karmienia
        public string feedingNotes { get; set; }           //Uwagi dotyczące karmienia
        public string hoursOfWalks { get; set; }           //zwyczajowe godziny spacerów
        public int lengthOfWalks { get; set; }             //długość spacerów
        public string healthStatus { get; set; }           //Stan zdrowia
        public string veterinarianIndication { get; set; } //wskazania weterynarza
        public DateTime Vaccination { get; set; }          //data ostatniego szczepienia
        public DateTime ticksProtection { get; set; }      //ochrona przeciw kleszczom
        public string vetInfo { get; set; }                //dane weterynarza
        public string characterDescription { get; set; }   //opis charakteru
        public string CatsReaction { get; set; }           //Reakcja na koty
        public string favToy { get; set; }                 //ulubiona zabawka
        public string knownCommands { get; set; }          //znane komendy
        public string beautyTreatments { get; set; }       //zabiegi pielęgnacyjne
        public string hotelStays { get; set; }             //wcześniejsze pobyty w hotelach

        public ClassDogs() { }

        public ClassDogs(ClassDogs dog)
        {
            dog.idDog = idDog;
            dog.name = name;
            dog.sterilization = sterilization;
            dog.lastEstrus = lastEstrus;
            dog.breed = breed;
            dog.color = color;
            dog.age = age;
            dog.weight = weight;
            dog.food = food;
            dog.feedingFrequency = feedingFrequency;
            dog.feedingHour = feedingHour;
            dog.feedingNotes = feedingNotes;
            dog.hoursOfWalks = hoursOfWalks;
            dog.lengthOfWalks = lengthOfWalks;
            dog.healthStatus = healthStatus;
            dog.veterinarianIndication = veterinarianIndication;
            dog.Vaccination = Vaccination;
            dog.ticksProtection = ticksProtection;
            dog.vetInfo = vetInfo;
            dog.characterDescription = characterDescription;
            dog.CatsReaction = CatsReaction;
            dog.favToy = favToy;
            dog.knownCommands = knownCommands;
            dog.beautyTreatments = beautyTreatments;
            dog.hotelStays = hotelStays;


        }
    }
}
