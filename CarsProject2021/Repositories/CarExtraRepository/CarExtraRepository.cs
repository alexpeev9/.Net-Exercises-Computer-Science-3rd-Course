﻿using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.CarExtraRepository
{

    public class CarExtraRepository : ICarExtraRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public CarExtraRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(CarExtra carextra)
        {
            _appDbContext.Entry(carextra).State = EntityState.Detached;
            _appDbContext.CarExtra.Add(carextra);
            _appDbContext.SaveChanges();
        }
        public ICollection<CarExtra> GetCarExtras(int carId) => _appDbContext.CarExtra.Include(x=>x.Car)
                                                                                      .Include(x => x.Extra)    
                                                                                      .Where(x => x.CarId == carId).ToList();
    }
}
