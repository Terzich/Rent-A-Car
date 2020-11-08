using Microsoft.EntityFrameworkCore;
using RentACar.DAL.Configuration;
using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.DB
{
    public class RentACarDbContext:DbContext
    {

        public RentACarDbContext(DbContextOptions<RentACarDbContext>options):base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<BookedCar> BookedCars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarConfiguration).Assembly);


            base.OnModelCreating(modelBuilder);

        }

    }
}
