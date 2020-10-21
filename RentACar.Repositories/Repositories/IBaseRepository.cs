using RentACar.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Repositories.Repositories
{
  public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetbyId(int id);
        List<TEntity> GetAll();
        TEntity Add(TEntity obj);

        TEntity Update(TEntity obj, int id);

       
    }
}
