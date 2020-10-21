using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class BookedCar : Base
    {
        [Key]
        public int BookedCarID { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Price { get; set; }


        public int UserID { get; set; }
        public User User { get; set; }


        public int CarID { get; set; }
        public Car Car { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
