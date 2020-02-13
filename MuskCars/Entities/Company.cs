namespace MuskCars.Entities
{
    public class Company : IHasId
    {
        public int Id { get; set; }
        public string EnglishName { get; private set; }

        public Company(int id, string name)
        {
            Id = id;
            EnglishName = name;
        }
    }
}
