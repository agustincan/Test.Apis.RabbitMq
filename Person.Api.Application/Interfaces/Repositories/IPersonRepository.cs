using Person.Api.Domain.Dtos;

namespace Person.Api.Application.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<PersonDto>> GetByName(string name);
        Task<IEnumerable<PersonDto>> GetAllWithIncludes();
    }
}