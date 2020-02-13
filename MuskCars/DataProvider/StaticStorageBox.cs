using MuskCars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskCars.DataProvider
{
    public class StaticStorageBox
    {
        public List<City> Cities { get; private set; }
        public List<Country> Countries { get; private set; }
        public List<Trademark> Trademarks { get; private set; }
        public List<Company> Companies { get; private set; }

        private static StaticStorageBox storageBox { get; set; }

        private StaticStorageBox()
        {
            Cities = new List<City>() {
                new City(0, "Rivne"),
                new City(1, "Kyiv"),
                new City(2, "Dusseldorf"),
                new City(3, "Berlin"),
                new City(4, "Paris")
            };
            Countries = new List<Country>() {
                new Country(0, "Ukraine"),
                new Country(1, "Germany"),
                new Country(2, "France")
            };
            Trademarks = new List<Trademark>()
            {
                new Trademark(0, "ZAZ"),
                new Trademark(1, "VAZ"),
                new Trademark(2, "LAZ"),
                new Trademark(3, "KRAZ"),
                new Trademark(4, "KAMAZ"),
                new Trademark(5, "UAZ"),
                new Trademark(6, "BELAZ"),
                new Trademark(7, "LUAZ")
            };
            Companies = new List<Company>()
            {
                new Company(0, "FixAndGo"),
                new Company(1, "SteelWheel"),
                new Company(2, "Carvice")
            };

        }

        public static StaticStorageBox GetInstance()
        {
            if (storageBox == null)
                storageBox = new StaticStorageBox();
            return storageBox;
        }


    }
}
