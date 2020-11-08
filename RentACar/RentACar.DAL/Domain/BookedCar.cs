using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Domain
{
    public class BookedCar:BaseEntity
    {
        public int UserId { get; set; }
        public int CarId { get; set; }

        public User User { get; set; }
        public Car Car { get; set; }
        
        public DateTime BookedFrom { get; set; }
        public DateTime BookedTo { get; set; }
        public int TotalPrice { get; set; }


    }
}
