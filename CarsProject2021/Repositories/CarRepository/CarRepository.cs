namespace Repositories.CarRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public CarRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Car> GetAllCars => _appDbContext.Cars
                .Include(x=>x.Brand)
                .Include(x => x.CarExtras)
                .ThenInclude(x => x.Extra)
                .AsNoTracking()
                .ToList();
        public Car GetCarById(int id) => _appDbContext.Cars
                    .Include(b => b.Brand)
                    .Include(x => x.CarExtras)
                    .ThenInclude(x => x.Extra)
                    .AsNoTracking()
                    .SingleOrDefault(x => x.Id == id);
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
            var oldcar = _appDbContext.Cars.Single(x => x.Id == car.Id);
            oldcar.Model = car.Model;
            oldcar.Year = car.Year;
            oldcar.HasInsurance = car.HasInsurance;
            oldcar.BrandId = car.BrandId;
            _appDbContext.Entry(oldcar).State = EntityState.Modified;
            //_appDbContext.Cars.Update(car);
            _appDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var car = _appDbContext.Cars.Find(id);
            _appDbContext.Cars.Remove(car);
            _appDbContext.SaveChanges();
        }
    }
}
