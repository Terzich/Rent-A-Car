using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Configuration
{
    public class BookedCarConfiguration:BaseEntityConfiguration<BookedCar>
    {
        public override void Configure(EntityTypeBuilder<BookedCar> builder)
        {
            base.Configure(builder);

            builder.HasOne(b => b.Car).WithMany(b => b.BookedCars).HasForeignKey(b => b.CarId);
            builder.HasOne(b => b.User).WithMany(b => b.BookedCars).HasForeignKey(b => b.UserId);

            


        }
    }
}
