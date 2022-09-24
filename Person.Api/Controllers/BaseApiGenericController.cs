using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Person.Api.Controllers;

[Route("api/v1{version:apiVersion}/[controller]")]
[ApiController]
public abstract class BaseApiGenericController<T>: ControllerBase
{
    private IMediator _mediatorInstance;
    private ILogger<T> _loggerInstance;

    protected IMediator mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>()!;
    protected ILogger<T> logger => _loggerInstance ??= HttpContext.RequestServices.GetService<ILogger<T>>()!;
}