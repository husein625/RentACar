using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class Role : Base
    {
        public int RoleID { get; set; }
        public String Name { get; set; }
    }
}
