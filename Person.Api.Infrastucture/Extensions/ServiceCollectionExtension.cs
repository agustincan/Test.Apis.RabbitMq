using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Person.Api.Application.Interfaces.Repositories;
using Person.Api.Infrastucture.Repositories;
using Repository.Core;

namespace Person.Api.Infrastucture.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastuctureLayer(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}