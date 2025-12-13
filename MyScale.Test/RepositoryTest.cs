using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyScale.Domain.Entities;
using MyScale.Repository.Context;
using MyScale.Repository.Repository;

namespace MyScale.Tests
{
    [TestClass]
    public class RepositoryTest
    {
        private MyScaleDbContext GetRealContext()
        {
            var connectionString = "Server=localhost;Port=3306;Database=MyScaleDB;User ID=developer;Password=123456789";

            var options = new DbContextOptionsBuilder<MyScaleDbContext>()
                .UseMySQL(connectionString)
                .Options;

            return new MyScaleDbContext(options);
        }

        [TestMethod]
        public void InserirHospitalNoBancoDeDados()
        {
            using (var context = GetRealContext())
            {
                var _hospitalRepository = new BaseRepository<Hospital>(context);

                var random = new Random().Next(1000, 9999);

                var hospital = new Hospital
                {
                    Name = $"Hospital Real {random}", 
                    CNPJ = $"11.111.111/000{random}",
                    Email = $"teste{random}@real.com",
                    Password = "123",
                    Username = $"admin_{random}",
                    MunicipalRegistry = $"{random}",
                    FoundationDate = new DateTime(1990, 1, 1),

                    Address = new Address
                    {
                        ZipCode = "16200-000",
                        Street = "Rua do Teste Real",
                        Number = $"{random}",
                        Neighborhood = "Centro",
                        City = "Birigui",
                        State = "SP"
                    }
                };

                _hospitalRepository.Insert(hospital);

                Console.WriteLine($"Hospital salvo com ID: {hospital.Id}");

                Assert.IsTrue(hospital.Id > 0, "O banco deveria ter gerado um ID");
            }
        }

        [TestMethod]
        public void InserirHealthAgentNoBancoDeDados()
        {
            using (var context = GetRealContext())
            {
                var _agentRepository = new BaseRepository<HealthAgent>(context);
                var random = new Random().Next(1000, 9999);

                var agent = new HealthAgent
                {
                    Name = $"Dr. Teste {random}",
                    Document = $"123.456.789-{random.ToString().Substring(0, 2)}",
                    Email = $"medico{random}@test.com",
                    Username = $"medico_{random}", 
                    Password = "senha_secreta",
                    BirthDate = new DateTime(1980, 5, 20),

                    Address = new Address
                    {
                        ZipCode = "00000-000",
                        Street = "Rua do Médico",
                        Number = $"{random}",
                        Neighborhood = "Bairro Saúde",
                        City = "São Paulo",
                        State = "SP"
                    }
                };

                _agentRepository.Insert(agent);
                context.SaveChanges();

                Console.WriteLine($"Médico salvo com ID: {agent.Id}");
                Assert.IsTrue(agent.Id > 0, "O ID do médico deveria ter sido gerado.");
            }
        }

        [TestMethod]
        public void InserirPlantaoVinculadoAHospitalNoBancoDeDados()
        {
            using (var context = GetRealContext())
            {
                var _hospitalRepository = new BaseRepository<Hospital>(context);
                var _shiftRepository = new BaseRepository<MedicalShift>(context);
                var random = new Random().Next(1000, 9999);

                var hospital = new Hospital
                {
                    Name = $"Hospital do Plantão {random}",
                    CNPJ = $"00.000.000/000{random}",
                    Email = $"plantao{random}@hosp.com",
                    Password = "123",
                    Username = $"admin_shift_{random}",
                    MunicipalRegistry = $"{random}",
                    FoundationDate = new DateTime(1990, 1, 1),
                    Address = new Address { ZipCode = "111", Street = "R", Number = "1", Neighborhood = "B", City = "C", State = "SP" }
                };

                _hospitalRepository.Insert(hospital);

                Console.WriteLine($"Hospital criado para o teste: ID {hospital.Id}");

                var plantao = new MedicalShift
                {
                    HospitalId = hospital.Id,

                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), // Daqui 5 dias
                    StartTime = DateTime.Now.AddDays(5).AddHours(8),       // 08:00
                    EndTime = DateTime.Now.AddDays(5).AddHours(20),        // 20:00
                    PaymentAmount = 2500.00m,

                    // HealthAgentId = null // Começa vazio (vaga aberta)
                };

                _shiftRepository.Insert(plantao);

                Console.WriteLine($"Plantão criado com ID: {plantao.Id}");

                Assert.IsTrue(plantao.Id > 0);
                Assert.AreEqual(hospital.Id, plantao.HospitalId);
                Assert.IsTrue(plantao.IsOpen, "O plantão deveria estar com status Aberto (sem médico).");
            }
        }
    }
}