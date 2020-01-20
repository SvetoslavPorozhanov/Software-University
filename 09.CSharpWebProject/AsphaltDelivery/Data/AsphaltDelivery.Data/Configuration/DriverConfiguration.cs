namespace AsphaltDelivery.Data.Configuration
{
    using AsphaltDelivery.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> driver)
        {
            driver
                .HasOne(d => d.Firm)
                .WithMany(f => f.Drivers)
                .HasForeignKey(d => d.FirmId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
