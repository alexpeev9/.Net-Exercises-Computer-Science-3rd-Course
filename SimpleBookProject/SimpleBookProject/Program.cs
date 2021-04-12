using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleBookProject.Data;
using SimpleBookProject.Repositories.BookRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBookProject
{

    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=BookDB;Trusted_Connection=True;");
            });
            services.AddScoped<IBookRepository, BookRepository>();
            //ServiceProvider = services.BuildServiceProvider();
            //DbInitializer.Seed(ServiceProvider.GetRequiredService<ApplicationDbContext>());
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1());
        }
    }
}
