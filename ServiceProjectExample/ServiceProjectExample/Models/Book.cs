namespace ServiceProjectExample.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    }
}
