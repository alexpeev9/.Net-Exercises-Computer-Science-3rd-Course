namespace DataAccess.Seed
{
    using DataStructure;
    using System.Collections.Generic;
    using System.Linq;
    public class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Brands.Any())
            {
                context.Brands.AddRange(Brands.Select(c => c.Value));
            }
            context.SaveChanges();
        }

        // Seed For Brands
        private static Dictionary<string, Brand> brands;
        public static Dictionary<string, Brand> Brands
        {
            get
            {
                if (brands == null)
                {
                    var brandList = new Brand[]
                    {
                        new Brand { Name = "Audi", Info = "Very good and fast cars."},
                        new Brand { Name = "BMW", Info = "Good for drifting." },
                        new Brand { Name = "Ford", Info = "Not good for summer." }
                    };

                    brands = new Dictionary<string, Brand>();

                    foreach (Brand brand in brandList)
                    {
                        brands.Add(brand.Name, brand);
                    }
                }
                return brands;
            }
        }
    }

}
