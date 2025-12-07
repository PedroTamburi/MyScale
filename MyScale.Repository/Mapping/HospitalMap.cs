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

public class HospitalMap : IEntityTypeConfiguration<Hospital>
{
    public HospitalMap()
    {

    }

    public void Configure(EntityTypeBuilder<Hospital> builder)
    {
        builder.ToTable("Hospitals");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.MunicipalRegistry)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(c => c.FoundationDate)
            .IsRequired();

        builder.Property(c => c.CNPJ)
            .IsRequired()
            .HasMaxLength(18);

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
            .IsRequired();

        builder.Property(c => c.IsActive)
            .HasDefaultValue(true);

        builder.OwnsOne(x => x.Address, addr =>
        {
            addr.ConfigureAddress(); // usa o metodo do extension para criar as propriedades do endereco
        });

        builder.HasMany(h => h.Shifts)
            .WithOne(s => s.Hospital)
            .HasForeignKey(s => s.HospitalId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
