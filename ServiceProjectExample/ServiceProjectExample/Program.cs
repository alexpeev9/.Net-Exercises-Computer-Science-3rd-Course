namespace ServiceProjectExample
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using ServiceProjectExample.Data;
    using ServiceProjectExample.Repositories;
    using ServiceProjectExample.Services;
    using System;
    using System.Windows.Forms;
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            //services.AddTransient<BookDbContext>();
            services.AddDbContext<BookDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=BookDbServices;Trusted_Connection=True;");
            });
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddTransient<IBookService, BookService>();
            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new BookForm());
        }
    }
}
