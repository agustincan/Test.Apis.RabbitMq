namespace Person.Api.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Number { get; set; }
        public bool? Active { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
    }

}