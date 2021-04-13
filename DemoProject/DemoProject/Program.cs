using DemoProject.Data;
using DemoProject.Repositories;
using DemoProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                // Server = „P„Œ„‚„r„y „‚„u„t „€„„ SQL
                // Database = „I„}„u „~„p „r„p„Š„p„„„p „q„p„x„p(„N„u „„„‚„‘„q„r„p „t„p „‘ „y„}„p„„„u „ƒ„Œ„x„p„t„u„~„p „r Sql)
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=BookDb3;Trusted_Connection=True;");
            });
            services.AddScoped<IBookRepository, BookRepository>();
            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1());
        }
    }
}
