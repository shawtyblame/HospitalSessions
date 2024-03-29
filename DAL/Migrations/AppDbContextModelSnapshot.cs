﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("Number")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 101L
                        },
                        new
                        {
                            Id = 2,
                            Number = 102L
                        },
                        new
                        {
                            Id = 3,
                            Number = 103L
                        });
                });

            modelBuilder.Entity("DAL.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Male"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Female"
                        });
                });

            modelBuilder.Entity("DAL.Entities.HealingEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int>("HealingEventTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Recommeandations")
                        .HasColumnType("text");

                    b.Property<int>("RequestVisitId")
                        .HasColumnType("integer");

                    b.Property<string>("Results")
                        .HasColumnType("text");

                    b.Property<DateTime>("Time")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("HealingEventTypeId");

                    b.HasIndex("RequestVisitId");

                    b.ToTable("HealingEvents");
                });

            modelBuilder.Entity("DAL.Entities.HealingEventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HealingEventTypes");
                });

            modelBuilder.Entity("DAL.Entities.Hospitalization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("Code")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateOfHospitalization")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DepartamentId")
                        .HasColumnType("integer");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HospitalizationConditionId")
                        .HasColumnType("integer");

                    b.Property<int>("HospitalizationStatusId")
                        .HasColumnType("integer");

                    b.Property<string>("Target")
                        .HasColumnType("text");

                    b.Property<int>("UserMainInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("HospitalizationConditionId");

                    b.HasIndex("HospitalizationStatusId");

                    b.HasIndex("UserMainInfoId");

                    b.ToTable("Hospitalizations");
                });

            modelBuilder.Entity("DAL.Entities.HospitalizationCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HospitalizationConditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Платно"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Бюджет"
                        });
                });

            modelBuilder.Entity("DAL.Entities.HospitalizationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HospitalizationStatus");
                });

            modelBuilder.Entity("DAL.Entities.MedicalCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("Number")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserMainInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserMainInfoId");

                    b.ToTable("MedicalCards");
                });

            modelBuilder.Entity("DAL.Entities.RequestVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateTime")
                        .HasColumnType("date");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int>("VisitorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("VisitorId");

                    b.ToTable("RequestVisits");
                });

            modelBuilder.Entity("DAL.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Doctor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Reseption"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Patient"
                        });
                });

            modelBuilder.Entity("DAL.Entities.UserAddictional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("InsurancePolicyNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("InsurancePolicyNumberEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserMainInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("WorkPlace")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserMainInfoId");

                    b.ToTable("UserAddictionals");
                });

            modelBuilder.Entity("DAL.Entities.UserCredentional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserCredentionals");
                });

            modelBuilder.Entity("DAL.Entities.UserMainInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("GenderId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("PassportNumber")
                        .HasColumnType("bigint");

                    b.Property<long>("PassportSeries")
                        .HasColumnType("bigint");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<int>("UserCredentionalId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("UserCredentionalId");

                    b.ToTable("UserMainInfos");
                });

            modelBuilder.Entity("DAL.Entities.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int>("MedicalCardId")
                        .HasColumnType("integer");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("Recommendation")
                        .HasColumnType("text");

                    b.Property<int>("RequestVisitId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("MedicalCardId");

                    b.HasIndex("RequestVisitId");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("DAL.Entities.HealingEvent", b =>
                {
                    b.HasOne("DAL.Entities.HealingEventType", "HealingEventType")
                        .WithMany()
                        .HasForeignKey("HealingEventTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.RequestVisit", "RequestVisit")
                        .WithMany()
                        .HasForeignKey("RequestVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HealingEventType");

                    b.Navigation("RequestVisit");
                });

            modelBuilder.Entity("DAL.Entities.Hospitalization", b =>
                {
                    b.HasOne("DAL.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("DAL.Entities.HospitalizationCondition", "HospitalizationConditon")
                        .WithMany()
                        .HasForeignKey("HospitalizationConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.HospitalizationStatus", "HospitalizationStatus")
                        .WithMany()
                        .HasForeignKey("HospitalizationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.UserMainInfo", "UserMainInfo")
                        .WithMany()
                        .HasForeignKey("UserMainInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("HospitalizationConditon");

                    b.Navigation("HospitalizationStatus");

                    b.Navigation("UserMainInfo");
                });

            modelBuilder.Entity("DAL.Entities.MedicalCard", b =>
                {
                    b.HasOne("DAL.Entities.UserMainInfo", "UserMainInfo")
                        .WithMany()
                        .HasForeignKey("UserMainInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMainInfo");
                });

            modelBuilder.Entity("DAL.Entities.RequestVisit", b =>
                {
                    b.HasOne("DAL.Entities.UserMainInfo", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.UserMainInfo", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("DAL.Entities.UserAddictional", b =>
                {
                    b.HasOne("DAL.Entities.UserMainInfo", "UserMainInfo")
                        .WithMany()
                        .HasForeignKey("UserMainInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMainInfo");
                });

            modelBuilder.Entity("DAL.Entities.UserCredentional", b =>
                {
                    b.HasOne("DAL.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DAL.Entities.UserMainInfo", b =>
                {
                    b.HasOne("DAL.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.UserCredentional", "UserCredentional")
                        .WithMany()
                        .HasForeignKey("UserCredentionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("UserCredentional");
                });

            modelBuilder.Entity("DAL.Entities.Visit", b =>
                {
                    b.HasOne("DAL.Entities.UserMainInfo", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.MedicalCard", "MedicalCard")
                        .WithMany()
                        .HasForeignKey("MedicalCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.RequestVisit", "RequestVisit")
                        .WithMany()
                        .HasForeignKey("RequestVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("MedicalCard");

                    b.Navigation("RequestVisit");
                });
#pragma warning restore 612, 618
        }
    }
}
