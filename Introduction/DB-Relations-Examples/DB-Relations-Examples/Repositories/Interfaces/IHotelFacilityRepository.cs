using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Relations_Examples.Repositories.Interfaces
{
    public interface IHotelFacilityRepository
    {
        void DeleteHotelFacility(int hotelId,int facilityId);
    }
}
