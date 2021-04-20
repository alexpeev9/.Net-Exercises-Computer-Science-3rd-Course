using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.ExtraRepository
{
    public class ExtraRepository : IExtraRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public ExtraRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Extra> GetAllExtras => _appDbContext.Extras.ToList();

        public Extra GetExtraByName(string name) => _appDbContext.Extras
                   .Include(b => b.CarExtras)
                   .AsNoTracking()
                   .SingleOrDefault(x => x.Name == name);
    }
}
