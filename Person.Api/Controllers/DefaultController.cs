using Microsoft.AspNetCore.Mvc;

namespace Person.Api.Controllers;

[ApiController]
[Route("/")]
public class DefaultController : ControllerBase
{
    // GET
    [HttpGet]
    public string Index()
    {
        return "Person Api Running";
    }
}