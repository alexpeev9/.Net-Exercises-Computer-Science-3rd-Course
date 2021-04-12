namespace DataAccess.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using DataStructure;
    using DataAccess.Repositories.Interfaces;

    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public CarRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Car Car(int id) => _appDbContext.Cars
                    .Include(b => b.Brand)
                    .AsNoTracking()
                    .SingleOrDefault(x=>x.Id == id);

        public IEnumerable<Car> Cars => _appDbContext.Cars
                    .Include(b => b.Brand)
                    .AsNoTracking()
                    .ToList();

        public void Add(Car car)
        {
            if(_appDbContext.Cars.Any(c=>c.Model == car.Model))
            {
                throw new Exception($"{car.Model} is already taken");
            }
            _appDbContext.Cars.Add(car);
            _appDbContext.SaveChanges();
        }
        public void Edit(Car car)
        {
            // because reflection
            _appDbContext.Entry(car).State = EntityState.Modified;
            //_appDbContext.Cars.Update(car);
            _appDbContext.SaveChanges();
        }
        public void Delete(Car car)
        {
            _appDbContext.Cars.Remove(car);
            _appDbContext.SaveChanges();
        }
    }
}
