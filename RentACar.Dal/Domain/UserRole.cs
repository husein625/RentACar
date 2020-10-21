using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class UserRole : Base
    {
        [Key]
        public int UserRoleD { get; set; }


        public int UserID { get; set; }
        public User User { get; set; }


        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
