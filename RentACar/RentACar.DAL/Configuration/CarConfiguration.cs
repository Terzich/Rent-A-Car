using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Configuration
{
    public class CarConfiguration:BaseEntityConfiguration<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.YearOfProduction).HasMaxLength(2020);
            builder.HasMany(b => b.BookedCars).WithOne(b => b.Car).HasForeignKey(b => b.CarId);

            builder.HasData(new List<Car>
            {
                new Car
                {
                    Id=1,
                    Name="Mercedes Benz C220",
                    HorsePower=131,
                    YearOfProduction=2012,
                    NumberOfDoors=5,
                    Color="Black"
                },
                new Car
                {
                    Id=2,
                    Name="Mercedes Benz E220",
                    HorsePower=151,
                    YearOfProduction=2014,
                    NumberOfDoors=5,
                    Color="Red"
                },
                new Car
                {
                    Id=3,
                    Name="Audi A6",
                    HorsePower=131,
                    YearOfProduction=2013,
                    NumberOfDoors=5,
                    Color="White"
                },

            });


        }
    }
}
