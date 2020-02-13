using MuskCars.DataProvider;
using MuskCars.Entities;
using System.Linq;

namespace MuskCars.BusinessLogic
{
    public static class AppointentExtensions
    {
        public static dynamic AsCustomerView(this Appointment appt)
        {
            var staticStorageBox = StaticStorageBox.GetInstance();
            return appt == null ? null : new
           {
               UserName = $"[{appt.UserId}] {(StorageBox.GetInstance().Users.Get(appt.UserId)?.UserName ?? "<unknown user>")}",
               Trademark = staticStorageBox.Trademarks.First(t => t.Id == appt.TrademarkId),
               CompanyName = staticStorageBox.Companies.First(c => c.Id == appt.CompanyId),
               Time = appt.Time
           };
        }
    }
}
