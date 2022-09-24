namespace Person.Api.Application.Features.Persons.Queries
{
    public class GetAllResponse
    {
        public GetAllResponse()
        {
            
        }
        public IEnumerable<Domain.Entities.Person> Persons { get; set; }
    }    
}

