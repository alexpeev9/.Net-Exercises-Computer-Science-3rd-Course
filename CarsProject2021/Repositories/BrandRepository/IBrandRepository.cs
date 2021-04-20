namespace Repositories.BrandRepository
{
    using Models;
    using System.Collections.Generic;
    public interface IBrandRepository
    {
        Brand GetBrandById(int id);
        IEnumerable<Brand> GetAllBrands { get; }
    }
}
