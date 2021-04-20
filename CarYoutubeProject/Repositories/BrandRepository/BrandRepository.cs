using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.BrandRepository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _appDbContext;
    public BrandRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public IEnumerable<Brand> GetAllBrands => _appDbContext.Brands
            .Include(x => x.Cars)
            .ToList();

    public Brand GetBrandById(int id) => _appDbContext.Brands
                .AsNoTracking()
                .SingleOrDefault(x => x.Id == id);
}
}

