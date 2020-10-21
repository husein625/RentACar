
using RentACar.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Repositories.Repositories
{
   public interface IUserRepository : IBaseRepository<User>
    {
        User LogIn(String username, String password);
    }
}
