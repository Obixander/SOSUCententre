using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SosuCentre.Entities;
namespace SosuCentre.DataAccess
{
    public class SosuCentreContext : DbContext
    {

        public SosuCentreContext(DbContextOptions<SosuCentreContext> options)
            : base(options)
        {

        }

        public DbSet<Address> Address { get; set; } = null!;
        public DbSet<CareCenter> CareCenters { get; set; } = null!;
        public DbSet<Diagnosis> Diagnoses { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Medicine> Medicines { get; set; } = null!;
        public DbSet<Prescription> Prescriptions { get; set; } = null!;
        public DbSet<Resident> Residents { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Entities.Task> Tasks { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SosuCentreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Entities.Task>(entity =>
            //{
            //    entity.HasKey(e => e.TaskId);
            //    entity.Property(e => e.TaskId)
            //        .ValueGeneratedOnAdd();

            //    entity.HasOne(e => e.Resident);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.TimeStart)
            //        .IsRequired();

            //    entity.Property(e => e.TimeEnd)
            //        .IsRequired();

            //    entity.Property(e => e.Completed)
            //        .IsRequired();

            //    entity.HasMany(e => e.Employees)
            //        .WithMany(e => e.Tasks)
            //        .UsingEntity(j => j.ToTable("TaskEmployees"));
            //});

            //modelBuilder.Entity<Role>(entity =>
            //{
            //    entity.HasKey(e => e.RoleId);

            //    entity.Property(e => e.RoleId)
            //        .ValueGeneratedOnAdd();

            //    entity.Property(e => e.RoleName)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasMany(e => e.Employees)
            //        .WithMany(e => e.Role)
            //        .UsingEntity(j => j.ToTable("EmployeeRoles"));
            //});

            //modelBuilder.Entity<Medicine>(entity =>
            //{
            //    entity.HasKey(e => e.MedicineId);

            //    entity.Property(e => e.MedicineId)
            //        .ValueGeneratedOnAdd();

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Unit)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Amount)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Administered)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Employee>(entity =>
            //{
            //    entity.HasKey(e => e.EmployeeId);

            //    entity.Property(e => e.EmployeeId)
            //        .ValueGeneratedOnAdd();

            //    entity.HasMany(entity => entity.Tasks)
            //        .WithMany(entity => entity.Employees)
            //        .UsingEntity(j => j.ToTable("TaskEmployees"));

            //    entity.HasMany(entity => entity.Role)
            //        .WithMany(entity => entity.Employees)
            //        .UsingEntity(j => j.ToTable("EmployeeRoles"));

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(e => e.CareCenter);
            //});

            //modelBuilder.Entity<Resident>(entity =>
            //{
            //    entity.HasKey(e => e.ResidentId);

            //    entity.Property(e => e.ResidentId)
            //        .ValueGeneratedOnAdd();

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);                

            //    entity.Property(e => e.RoomNumber)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasMany(e => e.Diagnoses);

            //    entity.HasMany(e => e.Prescriptions);

            //    entity.Property(e => e.Notes)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Prescription>(entity =>
            //{
            //    entity.HasKey(e => e.PrescriptionId);

            //    entity.Property(e => e.PrescriptionId)
            //        .ValueGeneratedOnAdd();

            //    entity.Property(e => e.Amount)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Unit)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});


            modelBuilder.Entity<Address>().HasData(new Address { AddressId = 1, City = "Vejle", State = "Syd Jylland", Street = "Boulevarden 31", ZipCode="7100"});
            
            modelBuilder.Entity<CareCenter>().HasData(new { CareCenterId = 1, Name = "SosuCenter Vejle", AddressId = 1 });

            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 1, Name = "Alzheimer", Description = "Alzheimer er en sygdom, der angriber hjernen og fører til en gradvis nedbrydning af hukommelse, tænkning og evnen til at udføre daglige opgaver." });
            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 2, Name = "Demens", Description = "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen. Symptomerne kan være problemer med hukommelsen, sprog, orientering og erkendelse." });
            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 3, Name = "Parkinson", Description = "Parkinsons sygdom er en kronisk sygdom, der skyldes en gradvis nedbrydning af hjerneceller, der producerer signalstoffet dopamin. Sygdommen medfører langsomme bevægelser, stivhed og rysten." });
            
            modelBuilder.Entity<Employee>().HasData(new {EmployeeId = 1, Name = "John Smith", CareCenterId = 1});
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 2, Name = "Chris William", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 3, Name = "simon lastname", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 4, Name = "John Doe", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 5, Name = "Jane Doe", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 1, Name = "Mads Mikkel", RoomNumber = "32", Notes = "HE Suck big fat", CareCenterId = 1});
            modelBuilder.Entity<Entities.Task>().HasData(new { TaskId = 1, Name = "Giv Medicin", TimeStart = DateTime.Now, TimeEnd = DateTime.Now.AddHours(2), ResidentId = 1, Completed = false, Notes = "Husk at give vand med medicinet" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 1, Name = "Tyrol", Amount = 20, Unit = "mg", Administered = false, TaskId = 1});







            base.OnModelCreating(modelBuilder);
        }
    }   

}
