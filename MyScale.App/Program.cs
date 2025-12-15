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
using System.Windows.Forms;

namespace MyScale.App
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = ConfigureServices();

            ServiceProvider = services.BuildServiceProvider();

            var loginForm = ServiceProvider.GetRequiredService<LoginForm>();

            System.Windows.Forms.Application.Run(loginForm);
        }

        private static IServiceCollection ConfigureServices()
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

            // --- D. SERVICES ---
            services.AddScoped<IMedicalShiftService, MedicalShiftService>();

            // --- E. FORMULÁRIOS ---
            services.AddTransient<RegisterForm>();

            services.AddTransient<LoginForm>();
            services.AddTransient<InitialForm>(); 

            return services;
        }
    }
}