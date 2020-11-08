using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Configuration
{
    public class UserConfiguration:BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.City).WithMany(b => b.Users).HasForeignKey(b => b.CityId);
            builder.HasMany(b => b.BookedCars).WithOne(b => b.User).HasForeignKey(b => b.UserId);

            builder.HasData(new List<User>
            {
                new User
                {
                    Id=1,
                    FirstName="Ahmed",
                    Lastname="Terzić",
                    DateofBirth=new DateTime(1999,01,13),
                    Username="Terzich",
                    CityId=1
                },
                new User
                {
                    Id=2,
                    FirstName="Nihad",
                    Lastname="Hrustić",
                    DateofBirth=new DateTime(1998,04,23),
                    Username="Nixi",
                    CityId=2

                },
                new User
                {
                    Id=3,
                    FirstName="Zlatan",
                    Lastname="Haljeta",
                    DateofBirth=new DateTime(1998,11,13),
                    Username="Zlaja",
                    CityId=3

                },
            });

        }
    }
}
