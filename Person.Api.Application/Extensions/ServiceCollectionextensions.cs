using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Person.Api.Infrastucture.Repositories;
using Repository.Core;

namespace Person.Api.Application.Extensions;

public static class ServiceCollectionextensions
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        //services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
    
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
        //services.AddTransient<IPersonRepository, ProductRepository>();
        services.AddTransient<IPersonRepository, PersonRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        return services;
    }
}