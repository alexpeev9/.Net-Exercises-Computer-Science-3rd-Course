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
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=HotelDataBase;Trusted_Connection=True;");
            });
            ServiceProvider = services.BuildServiceProvider();
        }

        static void Main(string[] args)
        {
            ConfigureServices();
            Console.WriteLine("Hello World!");

        }
    }
}
