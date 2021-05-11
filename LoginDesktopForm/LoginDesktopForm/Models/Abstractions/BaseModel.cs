using System.ComponentModel.DataAnnotations;

namespace LoginDesktopForm.Models.Abstractions
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
