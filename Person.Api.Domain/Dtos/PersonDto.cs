namespace Person.Api.Domain.Dtos
{
    public record PersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public virtual IEnumerable<AddressDto>? Addresses { get; set; }
    }   
}