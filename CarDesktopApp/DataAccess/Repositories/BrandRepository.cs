namespace DataAccess.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Collections.Generic;
    using DataStructure;
    using DataAccess.Repositories.Interfaces;

    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public BrandRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Brand Brand => _appDbContext.Brands
                    .Include(b => b.Cars)
                    .AsNoTracking()
                    .SingleOrDefault();
        public List<Brand> Brands => _appDbContext.Brands
                    .Include(b => b.Cars)
                    .AsNoTracking()
                    .ToList();
    }
}
