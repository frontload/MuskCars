using System.Collections.Generic;

namespace MuskCars.Entities
{
    public class CarWorkshop : IHasId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Trademarks { get; set; }
        public int City_Id { get; set; }
        public string PostalCode { get; set; }
        public int Country_Id { get; set; }
    }
}
