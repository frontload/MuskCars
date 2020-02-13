namespace MuskCars.Entities
{
    public class User : IHasId
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int City_Id { get; set; }
        public string PostalCode { get; set; }
        public int Country_Id { get; set; }
    }
}
