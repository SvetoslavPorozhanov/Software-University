namespace AsphaltDelivery.Data.Configuration
{
    using AsphaltDelivery.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TruckConfiguration : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> truck)
        {
            truck
                .HasOne(t => t.Firm)
                .WithMany(f => f.Trucks)
                .HasForeignKey(t => t.FirmId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
