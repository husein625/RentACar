using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class Contact : Base
    {
        [Key]
        public int ContactID { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

    }
}
