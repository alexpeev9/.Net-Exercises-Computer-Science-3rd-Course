namespace DataStructure
{
    using System.Collections.Generic;
    public class Brand : BaseModel
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
