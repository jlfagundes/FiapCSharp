using PetWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace PetWebAPI.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("PetConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}