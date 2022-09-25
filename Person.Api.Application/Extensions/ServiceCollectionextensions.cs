using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Person.Api.Application.Interfaces.Repositories;
using Repository.Core;

namespace Person.Api.Application.Extensions;

public static class ServiceCollectionextensions
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}