using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyScale.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HealthAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Document = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LoginDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    Address_Street = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Address_Number = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Address_Neighborhood = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Address_City = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Address_State = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Address_ZipCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Address_Complement = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthAgents", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    MunicipalRegistry = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: false),
                    FoundationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LoginDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    Address_Street = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Address_Number = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Address_Neighborhood = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Address_City = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Address_State = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Address_ZipCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Address_Complement = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicalShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    HealthAgentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalShifts_HealthAgents_HealthAgentId",
                        column: x => x.HealthAgentId,
                        principalTable: "HealthAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalShifts_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalShifts_HealthAgentId",
                table: "MedicalShifts",
                column: "HealthAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalShifts_HospitalId",
                table: "MedicalShifts",
                column: "HospitalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalShifts");

            migrationBuilder.DropTable(
                name: "HealthAgents");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
