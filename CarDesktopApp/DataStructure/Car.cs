namespace DataStructure
{
    using System.ComponentModel.DataAnnotations;
    public class Car : BaseModel
    {
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}
