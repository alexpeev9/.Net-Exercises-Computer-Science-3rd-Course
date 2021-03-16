namespace DB_Relations_Examples.Repositories
{
    using DB_Relations_Examples.Models;
    using DB_Relations_Examples.Repositories.Interfaces;

    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class FacilityRepository : IFacilityRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public FacilityRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Facility> GetAllFacilities => _appDbContext.Facilities.AsNoTracking().ToList();

        public Facility GetFacilitiyById(int id) => _appDbContext.Facilities.AsNoTracking().SingleOrDefault(x => x.Id == id);

        public void AddFacility(Facility facility)
        {
            _appDbContext.Facilities.Add(facility);
            _appDbContext.SaveChanges();
        }


        public void UpdateFacility(Facility facility)
        {
            _appDbContext.Entry(facility).State = EntityState.Modified;
            //_appDbContext.Facilities.Update(facility);
            _appDbContext.SaveChanges();
        }

        public void DeleteFacility(Facility facility)
        {
            _appDbContext.Facilities.Remove(facility);
            _appDbContext.SaveChanges();
        }
    }
}
