using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class Car : BaseEntity
    {
        public Car(String createdBy) : base(createdBy)
        {

        }

        public DateTime Year { get; set; }

        public int HorsePower { get; set; }
        public int NumberOfDoors { get; set; }
        public int Price { get; set; }
        public String ImageURL { get; set; }



        public int ColorID { get; set; }
        public Colors Color { get; set; }

        public List<BookedCar> BookedCars { get; set; }


    }
}
