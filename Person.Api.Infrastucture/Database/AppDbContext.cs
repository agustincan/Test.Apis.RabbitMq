using Microsoft.EntityFrameworkCore;
using Person.Api.Domain.Entities;


namespace Person.Api.Infrastucture.DataBase
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        DbSet<Domain.Entities.Person> Persons { get; set; }
        DbSet<Address> Addresses { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Entities.Person>().HasKey(x => x.Id);
            modelBuilder.Entity<Address>().HasKey(x => x.Id);
        }
    }    
}
