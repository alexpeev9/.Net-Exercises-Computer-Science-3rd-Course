using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class CarExtra
    {
        [Required]
        public int CarId { get; set; }
        [Required]
        public int ExtraId { get; set; }
        public Car Car { get; set; }
        public Extra Extra { get; set; }
    }
}
