using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Domain
{
    public class Car:BaseEntity
    {
        public string Name { get; set; }
        public int YearOfProduction { get; set; }
        public int NumberOfDoors { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public List<BookedCar> BookedCars { get; set; }
    }
}
