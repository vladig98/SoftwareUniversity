using BusTicketsSystem.Models;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class BusCompaniesInitializer
    {
        public static BusCompany[] GetBusCompanies()
        {
            BusCompany[] busCompanies = new BusCompany[]
            {
                new BusCompany() { Name = "Sunrise and Sunset Trips", Nationality = "Bulgaria", Rating = 10 },
                new BusCompany() { Name = "Globe Trotter", Nationality = "Bulgaria", Rating = 5.5 },
                new BusCompany() { Name = "Exploriana Travel", Nationality = "Bulgaria", Rating = 3.5 },
                new BusCompany() { Name = "Rhythm Travel", Nationality = "Bulgaria", Rating = 1 },
                new BusCompany() { Name = "Nation Urban Explorer Tours", Nationality = "Bulgaria", Rating = 8.5 },
                new BusCompany() { Name = "ConQuest Tours", Nationality = "Bulgaria", Rating = 9 },
                new BusCompany() { Name = "Planet at Your Fingertips", Nationality = "Bulgaria", Rating = 7.6 },
                new BusCompany() { Name = "Magical Places Tours", Nationality = "Bulgaria", Rating = 7.7 },
                new BusCompany() { Name = "Living on the Edge", Nationality = "Bulgaria", Rating = 9 },
                new BusCompany() { Name = "Here and There Tours", Nationality = "Bulgaria", Rating = 9.9 }
            };

            return busCompanies;
        }
    }
}
