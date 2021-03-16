using DB_Relations_Examples.Repositories;
using DB_Relations_Examples.Repositories.Interfaces;
using DB_Relations_Examples.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DB_Relations_Examples
{
    class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=HotelDataBaseFixed;Trusted_Connection=True;");
            });
            services.AddScoped<IFacilityRepository,FacilityRepository>();
            ServiceProvider = services.BuildServiceProvider();
            DbInitializer.Seed(ServiceProvider.GetRequiredService<ApplicationDbContext>());
        }

        static void Main(string[] args)
        {
            ConfigureServices();
            Console.WriteLine("Hello World!");

        }
    }
}
