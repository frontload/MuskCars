namespace MuskCars.Entities
{
    public class City : IHasId
    {
        public int Id { get; set; }
        public string EnglishName { get; private set; }

        public City(int code, string englishName)
        {
            Id = code;
            EnglishName = englishName;
        }
    }
}