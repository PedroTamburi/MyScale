using MyScale.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyScale.Repository.Mapping;

public class MedicalShiftMap : IEntityTypeConfiguration<MedicalShift>
{
    public void Configure(EntityTypeBuilder<MedicalShift> builder)
    {
        builder.ToTable("MedicalShifts");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.StartTime)
            .IsRequired();

        builder.Property(x => x.EndTime)
            .IsRequired();

        builder.Property(x => x.Date)
            .IsRequired();

        builder.Property(x => x.PaymentAmount)
            .IsRequired()
            .HasPrecision(18, 2);

        builder.Ignore(x => x.IsOpen);

        builder.HasOne(s => s.Hospital)
            .WithMany(h => h.Shifts)
            .HasForeignKey(s => s.HospitalId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.HealthAgent)
            .WithMany(ha => ha.Shifts)
            .HasForeignKey(s => s.HealthAgentId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);
    }
}