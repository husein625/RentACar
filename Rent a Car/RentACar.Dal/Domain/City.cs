using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        public int Name { get; set; }

    }
}
