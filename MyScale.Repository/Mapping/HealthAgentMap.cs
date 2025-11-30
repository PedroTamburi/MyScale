using MyScale.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyScale.Repository.Mapping.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScale.Repository.Mapping;

public class HealthAgentMap : IEntityTypeConfiguration<HealthAgent>
{
    public HealthAgentMap()
    {

    }

    public void Configure(EntityTypeBuilder<HealthAgent> builder)
    {
        builder.ToTable("HealthAgents");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Document)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(c => c.BirthDate)
            .IsRequired();

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Password)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(c => c.Username)
            .IsRequired()
            .HasMaxLength(45);

        builder.Property(c => c.RegisterDate)
            .HasDefaultValue("GETDATE()");

        builder.Property(c => c.IsActive)
            .HasDefaultValue(true);

        builder.OwnsOne(x => x.Address, addr =>
        {
           addr.ConfigureAddress();
        });

        builder.HasMany(h => h.MedicalShifts)
            .WithOne(s => s.HealthAgent)
            .HasForeignKey(s => s.HealthAgentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
