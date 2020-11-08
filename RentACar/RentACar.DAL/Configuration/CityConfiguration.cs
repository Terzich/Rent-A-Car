using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Configuration
{
    public class CityConfiguration:BaseEntityConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.HasMany(b => b.Users).WithOne(b => b.City).HasForeignKey(b => b.CityId);
            builder.HasData(new List<City>
            {
                new City
                {
                    Id=1,
                    Name="Sarajevo"
                },
                new City
                {
                    Id=2,
                    Name="Bugojno"
                },
                new City
                {
                    Id=3,
                    Name="Mostar"
                }

            });
        }
    }
}
