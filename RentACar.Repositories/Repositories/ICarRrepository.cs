using RentACar.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Repositories.Repositories
{
    interface ICarRrepository : IBaseRepository<Car>
    {
        List<Car> GetPopularCars();
    }
}
