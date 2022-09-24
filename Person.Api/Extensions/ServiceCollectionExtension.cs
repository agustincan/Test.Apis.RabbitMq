using Microsoft.EntityFrameworkCore;
using Person.Api.Infrastucture.DataBase;

namespace Person.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<AppDbContext>(options => options
                    .UseSqlServer(configuration.GetConnectionString("Default")));
        //.AddTransient<IDatabaseSeeder, DatabaseSeeder>();
    }
}