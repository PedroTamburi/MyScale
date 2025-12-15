using MyScale.Domain.Entities;
using MyScale.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MyScale.Repository.Context;

public class MyScaleDbContext : DbContext
{
    public MyScaleDbContext(DbContextOptions<MyScaleDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=MyScaleDB;User ID=developer;Password=123456789");
    }

    public DbSet<HealthAgent> HealthAgents { get; set; }
    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<MedicalShift> MedicalShifts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<MedicalShift>().HasKey(x => x.Id);
        modelBuilder.Entity<MedicalShift>()
        .Property(x => x.Date)
        .HasColumnType("date")
        .HasConversion(
            // Ao salvar: DateOnly -> DateTime
            dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),

            // Ao ler: DateTime -> DateOnly
            dateTime => DateOnly.FromDateTime(dateTime)
        );

        /*
        modelBuilder.Entity<HealthAgent>(new HealthAgentMap().Configure);
        modelBuilder.Entity<Hospital>(new HospitalMap().Configure);
        modelBuilder.Entity<MedicalShift>(new MedicalShiftMap().Configure);
        */

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyScaleDbContext).Assembly);
    }
}
