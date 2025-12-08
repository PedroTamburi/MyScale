using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Repository.Context;
using MyScale.Repository.Repository;
using MyScale.Service.Interfaces;
using MyScale.Service.Services;
using MyScale.Service.Validators;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyScale.Tests
{
    [TestClass]
    public class ServiceTest
    {
        private ServiceProvider _serviceProvider;

        public ServiceProvider ConfigureService()
        {
            var services = new ServiceCollection();

            var connectionString = "Server=localhost;Port=3306;Database=MyScaleDB;User ID=developer;Password=123456789";

            services.AddDbContext<MyScaleDbContext>(options =>
                options.UseMySQL(connectionString));

            services.AddScoped<IBaseRepository<MedicalShift>, BaseRepository<MedicalShift>>();
            services.AddScoped<IBaseRepository<Hospital>, BaseRepository<Hospital>>();

            services.AddScoped<IValidator<MedicalShift>, MedicalShiftValidator>();

            services.AddScoped<IMedicalShiftService, MedicalShiftService>();

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TesteCriarPlantao_FluxoCompleto_BancoReal()
        {
            _serviceProvider = ConfigureService();
            var medicalShiftService = _serviceProvider.GetService<IMedicalShiftService>();
            var context = _serviceProvider.GetService<MyScaleDbContext>();

            var rnd = new Random().Next(1000, 9999);

            var hospital = new Hospital
            {
                Name = $"Hospital Service Test {rnd}",
                CNPJ = $"11.111.111/000{rnd}",
                Email = $"service{rnd}@test.com",
                Password = "123",
                Username = $"admin_srv_{rnd}",
                MunicipalRegistry = $"{rnd}",
                FoundationDate = new DateOnly(2000, 1, 1),
                Address = new Address
                {
                    ZipCode = "16200-000",
                    Street = "Rua Service",
                    Number = "10",
                    Neighborhood = "B",
                    City = "C",
                    State = "SP"
                }
            };

            context.Hospitals.Add(hospital);
            context.SaveChanges();

            Console.WriteLine($"Hospital criado com ID: {hospital.Id}");

            var plantao = new MedicalShift
            {
                HospitalId = hospital.Id, 
                StartTime = DateTime.Now.AddHours(2),
                EndTime = DateTime.Now.AddHours(14),
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                PaymentAmount = 3500.00m
            };

            var result = medicalShiftService.Create(plantao);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            };

            Console.WriteLine(JsonSerializer.Serialize(result, options));
            Assert.IsTrue(result.IsSuccess);
            Assert.IsTrue(result.Data.Id > 0, "O ID do plantão deveria ter vindo do MySQL.");
        }
    }
}