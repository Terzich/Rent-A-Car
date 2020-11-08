using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.ViewModels
{
    public class CarViewModel
    {

        //public CarViewModel()
        //{

        //}
        //public CarViewModel(Car car)
        //{
        //    Id = car.Id;
        //    Name = car.Name;
        //    YearOfProduction = car.YearOfProduction;
        //    NumberOfDoors = car.NumberOfDoors;
        //    HorsePower = car.HorsePower;
        //    Color = car.Color;
        //    Description = car.Description;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfProduction { get; set; }
        public int NumberOfDoors { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
    }
}
