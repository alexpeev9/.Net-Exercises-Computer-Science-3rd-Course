using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB_Relations_Examples.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public TypeHotel Type { get; set; }
        public IList<HotelFacility> HotelFacilities { get; set; }
    }
}
