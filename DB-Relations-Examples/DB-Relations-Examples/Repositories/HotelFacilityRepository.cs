using DB_Relations_Examples.Models;
using DB_Relations_Examples.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Relations_Examples.Repositories
{
    public class HotelFacilityRepository : IHotelFacilityRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public HotelFacilityRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public void DeleteHotelFacility(int hotelId,int facilityId)
        {
            var hotel = _appDbContext.Hotels.SingleOrDefault(x => x.Id == hotelId);
            var facility = _appDbContext.Facilities.SingleOrDefault(x => x.Id == facilityId);
            HotelFacility hotelFacility = new HotelFacility { Facility = facility, Hotel = hotel , FacilityId = facilityId  , HotelId = hotelId };
            _appDbContext.HotelFacilities.Remove(hotelFacility);
            _appDbContext.SaveChanges();
        }
    }
}
