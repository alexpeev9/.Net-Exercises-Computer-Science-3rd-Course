namespace Models
{
    using System.ComponentModel.DataAnnotations;
    public class CarExtra
    {
        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [Required]
        public int ExtraId { get; set; }
        public Extra Extra { get; set; }
    }
}
