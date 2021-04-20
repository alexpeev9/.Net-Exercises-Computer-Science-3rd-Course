using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.BrandRepository
{
    public interface IBrandRepository
    {
        Brand GetBrandById(int id);
        IEnumerable<Brand> GetAllBrands { get; }
    }
}
