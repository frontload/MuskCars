using MuskCars.Entities;
using System;

namespace MuskCars.DataProvider
{
    public class ApptStorage : Storage<Appointment>
    {
        public void UpdateTime(int id, DateTime newTime) 
        {
            if (!storage.TryGetValue(id, out var appt))
                return;
            appt.Time = newTime;
        }
    }
}
