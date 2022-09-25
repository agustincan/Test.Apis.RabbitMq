namespace Person.Api.Domain.Dtos
{
    public record AddressDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Number { get; set; }
        public bool? Active { get; set; }
    }    
}

