namespace AsphaltDelivery.Data.Configuration
{
    using AsphaltDelivery.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TruckDriverConfiguration : IEntityTypeConfiguration<TruckDriver>
    {
        public void Configure(EntityTypeBuilder<TruckDriver> truckDriver)
        {
            truckDriver.HasKey(td => new { td.DriverId, td.TruckId });

            truckDriver
                .HasOne(td => td.Driver)
                .WithMany(d => d.DriverTrucks)
                .HasForeignKey(td => td.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            truckDriver
                .HasOne(td => td.Truck)
                .WithMany(t => t.TruckDrivers)
                .HasForeignKey(td => td.TruckId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
