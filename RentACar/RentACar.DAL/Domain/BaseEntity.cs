using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }

        protected BaseEntity()
        {
            DateCreated = DateTime.UtcNow;
        }
    }
}
