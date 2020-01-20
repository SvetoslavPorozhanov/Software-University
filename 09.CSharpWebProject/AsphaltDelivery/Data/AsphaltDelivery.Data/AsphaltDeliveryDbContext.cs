namespace AsphaltDelivery.Data
{
    using AsphaltDelivery.Data.Configuration;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class AsphaltDeliveryDbContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Truck> Trucks { get; set; }

        public DbSet<TruckDriver> TruckDrivers { get; set; }

        public DbSet<Firm> Firms { get; set; }

        public DbSet<AsphaltMixture> AsphaltMixtures { get; set; }

        public DbSet<AsphaltBase> AsphaltBases { get; set; }

        public DbSet<RoadObject> RoadObjects { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DataSettings.Connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TruckDriverConfiguration());
            modelBuilder.ApplyConfiguration(new DriverConfiguration());
            modelBuilder.ApplyConfiguration(new TruckConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
        }
    }
}
