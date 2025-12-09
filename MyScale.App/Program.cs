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

namespace MyScale.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Configura todos os serviços (Banco, Repositórios, Forms)
            var services = ConfigureServices();

            // 2. Constrói o "Provedor" que guarda essas peças
            using (var serviceProvider = services.BuildServiceProvider())
            {
                // 3. Pede para o provedor criar o InitialForm.
                // O provedor vai ver que o InitialForm precisa de repositórios
                // e vai injetá-los automaticamente.
                var initialForm = serviceProvider.GetRequiredService<InitialForm>();

                // 4. Roda a aplicação
                Application.Run(initialForm);
            }
        }

        // Método que ensina o programa a criar as coisas
        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // --- A. BANCO DE DADOS ---
            // (Substitua pela sua senha correta do MySQL)
            var connectionString = "Server=localhost;Port=3306;Database=MyScaleDB;User ID=root;Password=SUA_SENHA_AQUI";

            services.AddDbContext<MyScaleDbContext>(options =>
                options.UseMySQL(connectionString));

            // --- B. REPOSITÓRIOS ---
            services.AddScoped<IBaseRepository<Hospital>, BaseRepository<Hospital>>();
            services.AddScoped<IBaseRepository<HealthAgent>, BaseRepository<HealthAgent>>();
            services.AddScoped<IBaseRepository<MedicalShift>, BaseRepository<MedicalShift>>();

            // --- C. VALIDATORS (Opcional, mas bom ter) ---
            services.AddScoped<IValidator<MedicalShift>, MedicalShiftValidator>();
            services.AddScoped<IValidator<Hospital>, HospitalValidator>();

            // --- D. SERVICES ---
            services.AddScoped<IMedicalShiftService, MedicalShiftService>();

            // --- E. FORMULÁRIOS ---
            // Importante: Registre TODOS os forms que usam injeção
            services.AddTransient<InitialForm>();
            services.AddTransient<RegisterForm>();
            // services.AddTransient<LoginForm>(); // Quando criar o login

            return services;
        }
    }
}