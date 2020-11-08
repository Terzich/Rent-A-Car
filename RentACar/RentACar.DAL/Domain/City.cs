using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Domain
{
    public class City:BaseEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
