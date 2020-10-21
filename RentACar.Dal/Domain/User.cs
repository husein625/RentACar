using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Dal.Domain
{
    public class User : Base
    {
        [Key]
        public int UserID { get; set; }

        public String Name { get; set; }
        public String SurName { get; set; }
        public DateTime DateofBirth { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public int CityID { get; set; }
        public City City  { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<BookedCar> BookedCars { get; set; }

    }
}
