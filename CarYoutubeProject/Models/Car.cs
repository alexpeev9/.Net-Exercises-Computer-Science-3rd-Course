namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<CarExtra> CarExtras { get; set; }
    }
}
