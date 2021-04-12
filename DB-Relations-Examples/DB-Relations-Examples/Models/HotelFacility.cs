using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB_Relations_Examples.Models
{
    public class HotelFacility
    {
        public int HotelId { get; set; }
        public int FacilityId { get; set; }
        public Hotel Hotel { get; set; }
        public Facility Facility { get; set; }
    }
}
