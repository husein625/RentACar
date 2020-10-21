using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public String Comment { get; set; }
        public DateTime Date { get; set; }


        public int BookedCarID { get; set; }
        public BookedCar BookedCar { get; set; }
    }
}
