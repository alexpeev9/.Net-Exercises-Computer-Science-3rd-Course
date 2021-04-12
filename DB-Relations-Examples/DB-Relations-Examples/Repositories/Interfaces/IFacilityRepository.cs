using DB_Relations_Examples.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Relations_Examples.Repositories.Interfaces
{
    public interface IFacilityRepository
    {
        IEnumerable<Facility> GetAllFacilities { get; }
        Facility GetFacilitiyById (int id);
        void AddFacility(Facility facility);
        void UpdateFacility(Facility facility);
        void DeleteFacility(int id);
    }
}
