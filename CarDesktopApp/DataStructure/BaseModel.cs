namespace DataStructure
{
    using System.ComponentModel.DataAnnotations;
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
