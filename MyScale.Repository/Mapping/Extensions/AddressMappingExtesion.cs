using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyScale.Domain.Entities;

namespace MyScale.Repository.Mapping.Extensions;

public static class AddressMappingExtension
{
    // metodo para configurar o mapeamento do endereco em qualquer entidade
    public static void ConfigureAddress<T>(this OwnedNavigationBuilder<T, Address> builder)
        where T : class
    {
        builder.Property(p => p.Street).HasColumnName("Address_Street").HasMaxLength(150).IsRequired();
        builder.Property(p => p.Number).HasColumnName("Address_Number").HasMaxLength(20).IsRequired();
        builder.Property(p => p.Neighborhood).HasColumnName("Address_Neighborhood").HasMaxLength(100).IsRequired();
        builder.Property(p => p.City).HasColumnName("Address_City").HasMaxLength(100).IsRequired();
        builder.Property(p => p.State).HasColumnName("Address_State").HasMaxLength(2).IsRequired();
        builder.Property(p => p.ZipCode).HasColumnName("Address_ZipCode").HasMaxLength(20).IsRequired();
        builder.Property(p => p.Complement).HasColumnName("Address_Complement").HasMaxLength(100).IsRequired(false);
    }
}