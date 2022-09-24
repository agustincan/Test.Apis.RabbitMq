using Microsoft.EntityFrameworkCore;
using Repository.Core;

namespace Person.Api.Infrastucture.Repositories
{
    public class PersonRepository: IPersonRepository
    {
        private readonly IRepositoryAsync<Domain.Entities.Person> _repository;

        public PersonRepository(IRepositoryAsync<Domain.Entities.Person> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Domain.Entities.Person>> GetByName(string name)
        {
            return await _repository.Entities
                .Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name))
                .ToListAsync();
        }
    }
}