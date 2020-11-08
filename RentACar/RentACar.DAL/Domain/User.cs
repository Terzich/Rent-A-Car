using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Domain
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CityId { get; set; }
        public int BookedCarId { get; set; }
        public City City { get; set; }
        public List<BookedCar> BookedCars { get; set; }

    }
}
