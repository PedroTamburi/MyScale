using MyScale.Domain.Entities;
using MyScale.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;

namespace MyScale.Repository.Context;

public class MyScaleDbContext : DbContext
{
    public MyScaleDbContext(DbContextOptions<MyScaleDbContext>? options = null) : base(options)
    {
        Database.EnsureCreated();
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    //optionsBuilder.UseMySQL("Server=localhost;DataBase=IFSPStoreDb;Uid=Developer;Pwd=123456789");

    //    optionsBuilder.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=IFSPStoreDb;");
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Address>(new AddressMap().Configure);
        modelBuilder.Entity<HealthAgent>(new HealthAgentMap().Configure);
        modelBuilder.Entity<Hospital>(new HospitalMap().Configure);
        modelBuilder.Entity<MedicalShift>(new MedicalShiftMap().Configure);

        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryMap).Assembly);
    }

    public DbSet<Address> Categories { get; set; }
    public DbSet<HealthAgent> Cities { get; set; }
    public DbSet<Hospital> Customers { get; set; }
    public DbSet<MedicalShift> Products { get; set; }
}
