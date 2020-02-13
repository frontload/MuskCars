using MuskCars.DataProvider;
using MuskCars.Entities;
using System.Linq;

namespace MuskCars.BusinessLogic
{
    public static class UserExtensions
    {
        public static dynamic AsCustomerView(this User user)
        {
            var staticStorageBox = StaticStorageBox.GetInstance();
            return user == null ? null : new
            {
               Name = $"[{user.Id}] {user.UserName}",
               Email = user.Email,
               City = staticStorageBox.Cities.First(c => c.Id == user.City_Id),
               PostalCode = user.PostalCode,
               Country = staticStorageBox.Countries.First(c => c.Id == user.City_Id),
            };
        }
    }
}
