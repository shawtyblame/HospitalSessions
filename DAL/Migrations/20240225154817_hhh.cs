using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class hhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealingEventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealingEventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalizationConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalizationConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalizationStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalizationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCredentionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCredentionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCredentionals_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMainInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    PassportSeries = table.Column<long>(type: "bigint", nullable: false),
                    PassportNumber = table.Column<long>(type: "bigint", nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    UserCredentionalId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMainInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMainInfos_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMainInfos_UserCredentionals_UserCredentionalId",
                        column: x => x.UserCredentionalId,
                        principalTable: "UserCredentionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hospitalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserMainInfoId = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<long>(type: "bigint", nullable: true),
                    Target = table.Column<string>(type: "text", nullable: true),
                    Diagnosis = table.Column<string>(type: "text", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateOfHospitalization = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DepartamentId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: true),
                    HospitalizationConditionId = table.Column<int>(type: "integer", nullable: false),
                    HospitalizationStatusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitalizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hospitalizations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hospitalizations_HospitalizationConditions_HospitalizationC~",
                        column: x => x.HospitalizationConditionId,
                        principalTable: "HospitalizationConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitalizations_HospitalizationStatus_HospitalizationStatu~",
                        column: x => x.HospitalizationStatusId,
                        principalTable: "HospitalizationStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitalizations_UserMainInfos_UserMainInfoId",
                        column: x => x.UserMainInfoId,
                        principalTable: "UserMainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Number = table.Column<long>(type: "bigint", nullable: true),
                    UserMainInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCards_UserMainInfos_UserMainInfoId",
                        column: x => x.UserMainInfoId,
                        principalTable: "UserMainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestVisits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateTime = table.Column<DateOnly>(type: "date", nullable: false),
                    VisitorId = table.Column<int>(type: "integer", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestVisits_UserMainInfos_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "UserMainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestVisits_UserMainInfos_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "UserMainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddictionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    WorkPlace = table.Column<string>(type: "text", nullable: true),
                    InsurancePolicyNumber = table.Column<long>(type: "bigint", nullable: true),
                    InsurancePolicyNumberEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserMainInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddictionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddictionals_UserMainInfos_UserMainInfoId",
                        column: x => x.UserMainInfoId,
                        principalTable: "UserMainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealingEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false),
                    HealingEventTypeId = table.Column<int>(type: "integer", nullable: false),
                    Results = table.Column<string>(type: "text", nullable: true),
                    Recommeandations = table.Column<string>(type: "text", nullable: true),
                    RequestVisitId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealingEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealingEvents_HealingEventTypes_HealingEventTypeId",
                        column: x => x.HealingEventTypeId,
                        principalTable: "HealingEventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealingEvents_RequestVisits_RequestVisitId",
                        column: x => x.RequestVisitId,
                        principalTable: "RequestVisits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MedicalCardId = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Recommendation = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<int>(type: "integer", nullable: false),
                    RequestVisitId = table.Column<int>(type: "integer", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visit_MedicalCards_MedicalCardId",
                        column: x => x.MedicalCardId,
                        principalTable: "MedicalCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visit_RequestVisits_RequestVisitId",
                        column: x => x.RequestVisitId,
                        principalTable: "RequestVisits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visit_UserMainInfos_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "UserMainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { 1, 101L },
                    { 2, 102L },
                    { 3, 103L }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "HospitalizationConditions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Платно" },
                    { 2, "Бюджет" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Doctor" },
                    { 2, "Reseption" },
                    { 3, "Patient" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealingEvents_HealingEventTypeId",
                table: "HealingEvents",
                column: "HealingEventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HealingEvents_RequestVisitId",
                table: "HealingEvents",
                column: "RequestVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalizations_DepartmentId",
                table: "Hospitalizations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalizations_HospitalizationConditionId",
                table: "Hospitalizations",
                column: "HospitalizationConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalizations_HospitalizationStatusId",
                table: "Hospitalizations",
                column: "HospitalizationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitalizations_UserMainInfoId",
                table: "Hospitalizations",
                column: "UserMainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCards_UserMainInfoId",
                table: "MedicalCards",
                column: "UserMainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestVisits_DoctorId",
                table: "RequestVisits",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestVisits_VisitorId",
                table: "RequestVisits",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddictionals_UserMainInfoId",
                table: "UserAddictionals",
                column: "UserMainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCredentionals_RoleId",
                table: "UserCredentionals",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMainInfos_GenderId",
                table: "UserMainInfos",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMainInfos_UserCredentionalId",
                table: "UserMainInfos",
                column: "UserCredentionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_DoctorId",
                table: "Visit",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_MedicalCardId",
                table: "Visit",
                column: "MedicalCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_RequestVisitId",
                table: "Visit",
                column: "RequestVisitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealingEvents");

            migrationBuilder.DropTable(
                name: "Hospitalizations");

            migrationBuilder.DropTable(
                name: "UserAddictionals");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "HealingEventTypes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "HospitalizationConditions");

            migrationBuilder.DropTable(
                name: "HospitalizationStatus");

            migrationBuilder.DropTable(
                name: "MedicalCards");

            migrationBuilder.DropTable(
                name: "RequestVisits");

            migrationBuilder.DropTable(
                name: "UserMainInfos");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "UserCredentionals");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
