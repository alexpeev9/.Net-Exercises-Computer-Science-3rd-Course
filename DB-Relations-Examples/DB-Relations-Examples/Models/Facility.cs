using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB_Relations_Examples.Models
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<HotelFacility> HotelFacilities { get; set; }
    }
}
