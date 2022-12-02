﻿using Tarefa_ASPNET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarefa_ASPNET_MVC.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("FiapSmartCityConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}