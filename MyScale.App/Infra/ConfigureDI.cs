using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScale.App.Pages;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Repository.Context;
using MyScale.Repository.Repository;
using MyScale.Service.Interfaces;
using MyScale.Service.Services;
using MyScale.Service.Validators;

namespace MyScale.App.Infra
{
    
    public static class ConfigureDI
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // --- A. BANCO DE DADOS ---
            var connectionString = "Server=localhost;Port=3306;Database=MyScaleDB;User ID=root;Password=123456789";

            services.AddDbContext<MyScaleDbContext>(options =>
                options.UseMySQL(connectionString));

            // --- B. REPOSITÓRIOS ---
            services.AddScoped<IBaseRepository<Hospital>, BaseRepository<Hospital>>();
            services.AddScoped<IBaseRepository<HealthAgent>, BaseRepository<HealthAgent>>();
            services.AddScoped<IMedicalShiftRepository, MedicalShiftRepository>();
            services.AddScoped<IBaseRepository<MedicalShift>, BaseRepository<MedicalShift>>();

            // --- C. VALIDATORS ---
            services.AddScoped<IValidator<MedicalShift>, MedicalShiftValidator>();
            services.AddScoped<IValidator<Hospital>, HospitalValidator>();
            services.AddScoped<IValidator<HealthAgent>, HealthAgentValidator>();

            // --- D. SERVICES ---
            services.AddScoped<IMedicalShiftService, MedicalShiftService>();

            // --- E. FORMULÁRIOS ---
            services.AddTransient<RegisterForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<HospitalForm>();
            services.AddTransient<HealthAgentForm>();

            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }

}
