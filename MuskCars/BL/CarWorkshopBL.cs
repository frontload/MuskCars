using MuskCars.DataProvider;
using MuskCars.Entities;
using System.Collections.Generic;

namespace MuskCars.BusinessLogic
{
    public class CarWorkshopBL : IEntityProvider<CarWorkshop>
    {
        static private IStorage<CarWorkshop> workshops;

        public CarWorkshopBL()
        {
            workshops = StorageBox.GetInstance().CarWorkshops;
        }

        public void Add(CarWorkshop item)
        {
            if (workshops.ExistsKey(item.Id)
                || workshops.CountByPropertValue(i => i.Name == item.Name) > 0)
                return;
            workshops.Add(item);
        }

        public bool Delete(int id)
            => workshops.Delete(id);

        public CarWorkshop Get(int id)
            => workshops.Get(id);

        public IEnumerable<CarWorkshop> GetAll()
            => workshops.GetAll();
    }
}
