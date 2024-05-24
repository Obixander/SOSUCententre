﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SosuCentre.DataAccess;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    [DbContext(typeof(SosuCentreContext))]
    partial class SosuCentreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("EmployeeTask", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TasksTaskId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "TasksTaskId");

                    b.HasIndex("TasksTaskId");

                    b.ToTable("EmployeeTask");
                });

            modelBuilder.Entity("SosuCentre.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Vejle",
                            State = "Syd Jylland",
                            Street = "Boulevarden 31",
                            ZipCode = "7100"
                        });
                });

            modelBuilder.Entity("SosuCentre.Entities.CareCenter", b =>
                {
                    b.Property<int>("CareCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareCenterId"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareCenterId");

                    b.HasIndex("AddressId");

                    b.ToTable("CareCenters");

                    b.HasData(
                        new
                        {
                            CareCenterId = 1,
                            AddressId = 1,
                            Name = "SosuCenter Vejle"
                        });
                });

            modelBuilder.Entity("SosuCentre.Entities.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Diagnoses");

                    b.HasData(
                        new
                        {
                            DiagnosisId = 1,
                            Description = "Alzheimer er en sygdom, der angriber hjernen og fører til en gradvis nedbrydning af hukommelse, tænkning og evnen til at udføre daglige opgaver.",
                            Name = "Alzheimer"
                        },
                        new
                        {
                            DiagnosisId = 2,
                            Description = "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen. Symptomerne kan være problemer med hukommelsen, sprog, orientering og erkendelse.",
                            Name = "Demens"
                        },
                        new
                        {
                            DiagnosisId = 3,
                            Description = "Parkinsons sygdom er en kronisk sygdom, der skyldes en gradvis nedbrydning af hjerneceller, der producerer signalstoffet dopamin. Sygdommen medfører langsomme bevægelser, stivhed og rysten.",
                            Name = "Parkinson"
                        });
                });

            modelBuilder.Entity("SosuCentre.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            CareCenterId = 1,
                            Name = "John Smith"
                        },
                        new
                        {
                            EmployeeId = 2,
                            CareCenterId = 1,
                            Name = "Chris William"
                        },
                        new
                        {
                            EmployeeId = 3,
                            CareCenterId = 1,
                            Name = "simon lastname"
                        },
                        new
                        {
                            EmployeeId = 4,
                            CareCenterId = 1,
                            Name = "John Doe"
                        },
                        new
                        {
                            EmployeeId = 5,
                            CareCenterId = 1,
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("SosuCentre.Entities.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"));

                    b.Property<bool>("Administered")
                        .HasColumnType("bit");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineId");

                    b.HasIndex("TaskId");

                    b.ToTable("Medicines");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            Administered = false,
                            Amount = 20,
                            Name = "Tyrol",
                            TaskId = 1,
                            Unit = "mg"
                        });
                });

            modelBuilder.Entity("SosuCentre.Entities.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("SosuCentre.Entities.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentId"));

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResidentId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Residents");

                    b.HasData(
                        new
                        {
                            ResidentId = 1,
                            CareCenterId = 1,
                            Name = "Mads Mikkel",
                            Notes = "HE Suck big fat",
                            RoomNumber = "32"
                        });
                });

            modelBuilder.Entity("SosuCentre.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SosuCentre.Entities.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("TaskId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            Completed = false,
                            Name = "Giv Medicin",
                            Notes = "Husk at give vand med medicinet",
                            ResidentId = 1,
                            TimeEnd = new DateTime(2024, 5, 23, 16, 39, 40, 440, DateTimeKind.Local).AddTicks(322),
                            TimeStart = new DateTime(2024, 5, 23, 14, 39, 40, 440, DateTimeKind.Local).AddTicks(276)
                        });
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.HasOne("SosuCentre.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SosuCentre.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeTask", b =>
                {
                    b.HasOne("SosuCentre.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SosuCentre.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SosuCentre.Entities.CareCenter", b =>
                {
                    b.HasOne("SosuCentre.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SosuCentre.Entities.Diagnosis", b =>
                {
                    b.HasOne("SosuCentre.Entities.Resident", null)
                        .WithMany("Diagnoses")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SosuCentre.Entities.Employee", b =>
                {
                    b.HasOne("SosuCentre.Entities.CareCenter", "CareCenter")
                        .WithMany()
                        .HasForeignKey("CareCenterId");

                    b.Navigation("CareCenter");
                });

            modelBuilder.Entity("SosuCentre.Entities.Medicine", b =>
                {
                    b.HasOne("SosuCentre.Entities.Task", null)
                        .WithMany("Medicines")
                        .HasForeignKey("TaskId");
                });

            modelBuilder.Entity("SosuCentre.Entities.Prescription", b =>
                {
                    b.HasOne("SosuCentre.Entities.Resident", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SosuCentre.Entities.Resident", b =>
                {
                    b.HasOne("SosuCentre.Entities.CareCenter", null)
                        .WithMany("Residents")
                        .HasForeignKey("CareCenterId");
                });

            modelBuilder.Entity("SosuCentre.Entities.Task", b =>
                {
                    b.HasOne("SosuCentre.Entities.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("SosuCentre.Entities.CareCenter", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("SosuCentre.Entities.Resident", b =>
                {
                    b.Navigation("Diagnoses");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("SosuCentre.Entities.Task", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
