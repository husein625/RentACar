using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Dal.Domain
{
    public abstract class BaseEntity
    {

        public String CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }


        protected BaseEntity(String createdBy)
        {
            CreatedAt = DateTime.UtcNow;
            CreatedBy = createdBy;
        }
       
    }
}
