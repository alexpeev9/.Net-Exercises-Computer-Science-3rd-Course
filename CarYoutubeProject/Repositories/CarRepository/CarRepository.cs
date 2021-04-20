using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public CarRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Car> GetAllCars => _appDbContext.Cars.Include(x => x.Brand)
                                                                .Include(x => x.CarExtras).ThenInclude(x => x.Extra)
                                                                .AsNoTracking().ToList();
        public Car GetCarById(int id) => _appDbContext.Cars.Include(x => x.Brand)
                                                                .Include(x => x.CarExtras).ThenInclude(x => x.Extra)
                                                                .AsNoTracking().SingleOrDefault(x=>x.Id == id);
        public Car GetCarByModel(string model) => _appDbContext.Cars
                                                                    .Include(b => b.Brand)
                                                                    .Include(x => x.CarExtras)
                                                                    .ThenInclude(x => x.Extra)
                                                                    .AsNoTracking()
                                                                    .SingleOrDefault(x => x.Model == model);
        public int Add(Car car)
        {
            _appDbContext.Cars.Add(car);
            _appDbContext.SaveChanges();
            return car.Id;
        }
        public void Update(Car car)
        {
            Car oldCar = _appDbContext.Cars.Single(x => x.Id == car.Id);
            oldCar.Model = car.Model;
            oldCar.Year = car.Year;
            oldCar.BrandId = car.BrandId;
            _appDbContext.Entry(oldCar).State = EntityState.Modified;
            //_appDbContext.Cars.Update(car);
            _appDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Car car = _appDbContext.Cars.Find(id);
            _appDbContext.Cars.Remove(car);
            _appDbContext.SaveChanges();
        }
    }
}
