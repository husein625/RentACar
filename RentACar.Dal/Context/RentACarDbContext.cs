using RentACar.Dal.Domain;
using System;
using System.Collections.Generic;

namespace RentACar.Dal
{
    public class RentACarDbContext
    {
        public List<BookedCar> BookedCars { get; set; }
        public List<Car> Cars { get; set; }
        public List<City> Cities { get; set; }
        public List<Colors> Colors { get; set; }
        public List<Contact> Cantacts { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Role> Roles { get; set; }
        public List<User> Users { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
