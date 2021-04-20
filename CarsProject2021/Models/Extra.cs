namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Extra
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public IEnumerable<CarExtra> CarExtras { get; set; }
    }
}
