namespace Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<CarExtra> CarExtras { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server = localhost\MSSQLSERVER02
            //Database = CarDbYoutube
            optionsBuilder.EnableSensitiveDataLogging();
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=CarDbYoutube;Trusted_Connection=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
