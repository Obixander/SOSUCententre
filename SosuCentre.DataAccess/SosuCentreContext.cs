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
            
            modelBuilder.Entity<Address>().HasData(new Address { AddressId = 1, City = "Vejle", State = "Midt Jylland", Street = "Boulevarden 31", ZipCode="7100"});
            modelBuilder.Entity<CareCenter>().HasData(new { CareCenterId = 1, Name = "SosuCenter Vejle", AddressId = 1 });

            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 1, Name = "Alzheimer", Description = "Alzheimer er en sygdom, der angriber hjernen og fører til en gradvis nedbrydning af hukommelse, tænkning og evnen til at udføre daglige opgaver." });
            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 2, Name = "Demens", Description = "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen. Symptomerne kan være problemer med hukommelsen, sprog, orientering og erkendelse." });
            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 3, Name = "Parkinson", Description = "Parkinsons sygdom er en kronisk sygdom, der skyldes en gradvis nedbrydning af hjerneceller, der producerer signalstoffet dopamin. Sygdommen medfører langsomme bevægelser, stivhed og rysten." });
            modelBuilder.Entity<Employee>().HasData(new {EmployeeId = 1, Name = "John Smith", CareCenterId = 1});
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 2, Name = "Chris William", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 3, Name = "simon lastname", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 4, Name = "John Doe", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 5, Name = "Jane Doe", CareCenterId = 1 });
            //modelBuilder.Entity<Entities.Task>().HasData(new {  });
            //modelBuilder.Entity<Medicine>().HasData(new {MedicineId = 1, Name = "Panodil", Amount = 50, Administered = false, taskId = 1 });


            base.OnModelCreating(modelBuilder);
        }
    }   

}
