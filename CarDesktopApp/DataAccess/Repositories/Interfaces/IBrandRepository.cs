namespace DataAccess.Repositories.Interfaces
{
    using DataStructure;
    using System.Collections.Generic;
    public interface IBrandRepository
    {
        Brand Brand { get; }
        List<Brand> Brands { get; }
    }
}
