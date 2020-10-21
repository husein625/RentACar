using RentACar.Dal;
using RentACar.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Repositories.Repositories
{
    class CarRepository : BaseRepository<Car>, ICarRrepository
    {

        public CarRepository(RentACarDbContext context):base(context)
        {

        }

        public List<Car> GetPopularCars()
        {
            throw new NotImplementedException();
        }
    }
}
