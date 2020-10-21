using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class Colors : Base
    {
        [Key]
        public int ColorID { get; set; }

        public String Name { get; set; }

        public List<Car> Cars { get; set; }
    }
}
