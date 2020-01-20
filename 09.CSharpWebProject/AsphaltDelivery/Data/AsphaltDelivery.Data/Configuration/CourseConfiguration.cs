namespace AsphaltDelivery.Data.Configuration
{
    using AsphaltDelivery.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
            course
                .HasOne(c => c.Driver)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            course
                .HasOne(c => c.Truck)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TruckId)
                .OnDelete(DeleteBehavior.Restrict);

            course
                .HasOne(c => c.Firm)
                .WithMany(f => f.Courses)
                .HasForeignKey(c => c.FirmId)
                .OnDelete(DeleteBehavior.Restrict);

            course
                .HasOne(c => c.AsphaltMixture)
                .WithMany(am => am.Courses)
                .HasForeignKey(c => c.AsphaltMixtureId)
                .OnDelete(DeleteBehavior.Restrict);

            course
                .HasOne(c => c.AsphaltBase)
                .WithMany(ab => ab.Courses)
                .HasForeignKey(c => c.AsphaltBaseId)
                .OnDelete(DeleteBehavior.Restrict);

            course
                .HasOne(c => c.RoadObject)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.RoadObjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
