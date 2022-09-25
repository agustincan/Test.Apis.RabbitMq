using Microsoft.AspNetCore.Mvc;
using Person.Api.Application.Features.Persons.Queries;
using Person.Api.Application.Interfaces.Repositories;

namespace Person.Api.Controllers;

[ApiController]
[Route("[controller]", Name = "person")]
public class PersonController : BaseApiGenericController<PersonController>
{
    private readonly IPersonRepository _personRepository;

    public PersonController(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    // GET
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await mediator.Send(new GetAllQuery());
        return Ok(result.Persons);
    }
    [HttpGet]
    [Route("list-with-includes")]
    public async Task<IActionResult> ListWithIncludes()
    {
        var result = await _personRepository.GetAllWithIncludes();
        return Ok(result);
    }
}