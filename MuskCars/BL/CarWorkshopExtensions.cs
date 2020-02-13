using MuskCars.DataProvider;
using MuskCars.Entities;
using System.Linq;

namespace MuskCars.BusinessLogic
{
    public static class CarWorkshopExtensions
    {
        public static dynamic AsCustomerView(this CarWorkshop workshop)
        {
            var staticStorageBox = StaticStorageBox.GetInstance();
            return workshop == null ? null : new
            {
                CompanyName = workshop.Name,
                Trademarks = workshop.Trademarks.Select(t => staticStorageBox.Trademarks.First(t1 => t1.Id == t)),
                City = staticStorageBox.Cities.First(c => c.Id == workshop.City_Id),
                PostalCode = workshop.PostalCode,
                Country = staticStorageBox.Countries.First(c => c.Id == workshop.Country_Id)
            };
        }
    }
}
