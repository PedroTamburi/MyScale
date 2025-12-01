using MyScale.Domain.Entities;
using MyScale.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MyScale.Repository.Context;

public class MyScaleDbContext : DbContext
{
    public MyScaleDbContext(DbContextOptions<MyScaleDbContext>? options = null) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Address> HealthAgents { get; set; }
    public DbSet<HealthAgent> Hospitals { get; set; }
    public DbSet<Hospital> MedicalShifts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        /*
        modelBuilder.Entity<HealthAgent>(new HealthAgentMap().Configure);
        modelBuilder.Entity<Hospital>(new HospitalMap().Configure);
        modelBuilder.Entity<MedicalShift>(new MedicalShiftMap().Configure);
        */

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyScaleDbContext).Assembly);
    }
}
