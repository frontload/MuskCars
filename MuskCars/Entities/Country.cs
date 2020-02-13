using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskCars.Entities
{
    public class Country : IHasId
    {
        public int Id { get; set; }
        public string EnglishName { get; set; }
        public Country(int id, string name)
        {
            Id = id;
            EnglishName = name;
        }
    }
}
