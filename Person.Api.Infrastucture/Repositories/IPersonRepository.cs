namespace Person.Api.Infrastucture.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Domain.Entities.Person>> GetByName(string name);
    }
}