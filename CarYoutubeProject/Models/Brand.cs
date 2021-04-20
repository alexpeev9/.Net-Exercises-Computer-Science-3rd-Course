namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
