using Microsoft.AspNetCore.Mvc;
using Person.Api.Application.Features.Persons.Queries;

namespace Person.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : BaseApiGenericController<PersonController>
{
    // GET
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await mediator.Send(new GetAllQuery());
        return Ok(result.Persons);
    }
}