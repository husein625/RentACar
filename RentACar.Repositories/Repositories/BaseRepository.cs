using RentACar.Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Repositories.Repositories
{
   public  class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly RentACarDbContext _context;
        public BaseRepository(RentACarDbContext context)
        {
            _context = context;
        }
        public T Add(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public string SetCreator(string creator)
        {
            throw new NotImplementedException();
        }

        public DateTime SetDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public T Update(T obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
