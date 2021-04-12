namespace CarDesktopApp
{
    using Autofac;
    using DataAccess;
    using DataAccess.Repositories;
    using DataAccess.Repositories.Interfaces;
    using DataAccess.Seed;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Windows.Forms;
    static class StartUp
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=CarDbSplit;Trusted_Connection=True;");
            });
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            ServiceProvider = services.BuildServiceProvider();
            DbInitializer.Seed(ServiceProvider.GetRequiredService<ApplicationDbContext>());
        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new HomeForm());
        }
    }
}
