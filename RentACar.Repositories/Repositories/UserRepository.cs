using RentACar.Dal;
using RentACar.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Repositories.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(RentACarDbContext context) : base(context)
        {

        }
        public User LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
