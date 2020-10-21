using Microsoft.EntityFrameworkCore;
using RentACar.Dal.Domain;
using System;
using System.Collections.Generic;

namespace RentACar.Dal
{
    public class RentACarDbContext : DbContext
    {
        public DbSet<BookedCar> BookedCars { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Review> Reviews{ get; set; }
        public DbSet<Role> Roles{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserRole> UserRoles{ get; set; }
        
    

    }
}
