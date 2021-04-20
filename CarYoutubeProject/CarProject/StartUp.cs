namespace CarProject
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Repositories.BrandRepository;
    using Repositories.CarExtraRepository;
    using Repositories.CarRepository;
    using Repositories.ExtraRepository;
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
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=CarDbYoutube;Trusted_Connection=True");
            });
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IExtraRepository, ExtraRepository>();
            services.AddScoped<ICarExtraRepository, CarExtraRepository>();

            ServiceProvider = services.BuildServiceProvider();
        }
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
