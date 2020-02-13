using MuskCars.DataProvider;
using MuskCars.Entities;
using System;
using System.Collections.Generic;

namespace MuskCars.BusinessLogic
{
    public class ApptBL : IEntityProvider<Appointment>
    {
        static private ApptStorage appts;
        public ApptBL()
        {
            appts = StorageBox.GetInstance().Appointments;
        }

        public void Add(Appointment item)
        { 
            if (!appts.ExistsKey(item.Id))
                appts.Add(item);
        }

        public bool Delete(int id)
            => appts.Delete(id);

        public Appointment Get(int id)
            => appts.Get(id);

        public IEnumerable<Appointment> GetAll()
            => appts.GetAll();

        public void UpdateTime(int id, DateTime value)
            => appts.UpdateTime(id, value);
    }
}
