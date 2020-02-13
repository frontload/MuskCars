using System;

namespace MuskCars.Entities
{
    public class Appointment: IHasId
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrademarkId { get; set; }
        public int CompanyId { get; set; }
        public DateTime Time { get; set; }
    }
}
