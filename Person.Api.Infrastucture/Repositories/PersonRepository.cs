using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Person.Api.Application.Interfaces.Repositories;
using Person.Api.Domain.Dtos;
using Repository.Core;

namespace Person.Api.Infrastucture.Repositories
{
    public class PersonRepository: IPersonRepository
    {
        private readonly IRepositoryAsync<Domain.Entities.Person> _repository;
        private readonly IMapper _mapper;

        public PersonRepository(IRepositoryAsync<Domain.Entities.Person> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonDto>> GetByName(string name)
        {
            var result = await _repository.Entities
                .Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name))
                .ToListAsync();
            return _mapper.Map<IEnumerable<PersonDto>>(result);
        }
        public async Task<IEnumerable<PersonDto>> GetAllWithIncludes()
        {
            var result = await _repository.Entities
                .Include(p => p.Addresses)
                .ToListAsync();
            return _mapper.Map<IEnumerable<PersonDto>>(result);
        }
    }
}