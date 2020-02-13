namespace MuskCars.Entities
{
    public class Trademark
    {
        public int Id { get; set; }
        public string EnglishName { get; private set; }

        public Trademark(int code, string englishName)
        {
            Id = code;
            EnglishName = englishName;
        }
    }
}