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
        public DbSet<SubTask> SubTasks { get; set; } = null!;
        public DbSet<MedicineTask> MedicineTasks { get; set; } = null!;

        public DbSet<Entities.Assignment> Assignment { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SosuDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this ensures the creation of Task and MedicineTask tables
            //modelBuilder.Entity<SubTask>().ToTable("SubTasks");
            //modelBuilder.Entity<MedicineTask>().ToTable("MedicineTasks");
            
            //this changes the SubTaskId to MedicineTaskId in the MedicineTask table
           

            //this changes the AssignmentId1 to MedicinAssignmentId in the MedicineTask table
            modelBuilder.Entity<MedicineTask>().Property("AssignmentId").HasColumnName("MedicinAssignmentId");

            #region Address
            modelBuilder.Entity<Address>().HasData(new Address { AddressId = 1, City = "Vejle", State = "Syd Jylland", Street = "Boulevarden 31", ZipCode = "7100" });
            #endregion

            #region CareCenter
            modelBuilder.Entity<CareCenter>().HasData(new { CareCenterId = 1, Name = "SosuCenter Vejle", AddressId = 1 });
            #endregion

            #region Diagnosis
            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 1, Name = "Alzheimer", Description = "Alzheimer er en sygdom, der angriber hjernen og fører til en gradvis nedbrydning af hukommelse, tænkning og evnen til at udføre daglige opgaver." });
            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 2, Name = "Demens", Description = "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen. Symptomerne kan være problemer med hukommelsen, sprog, orientering og erkendelse." });
            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis { DiagnosisId = 3, Name = "Parkinson", Description = "Parkinsons sygdom er en kronisk sygdom, der skyldes en gradvis nedbrydning af hjerneceller, der producerer signalstoffet dopamin. Sygdommen medfører langsomme bevægelser, stivhed og rysten." });
            #endregion

            #region Employee            
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 1, Name = "John Smith", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 2, Name = "Chris William", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 3, Name = "simon lastname", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 4, Name = "John Doe", CareCenterId = 1 });
            modelBuilder.Entity<Employee>().HasData(new { EmployeeId = 5, Name = "Jane Simons", CareCenterId = 1 });
            #endregion

            #region Resident
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 1, Name = "Mads Mikkel", RoomNumber = "32", Notes = "HE Suck big fat", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 2, Name = "Lars Ulrich", RoomNumber = "21", Notes = "Plays drums loudly", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 3, Name = "Nina Hagen", RoomNumber = "15", Notes = "Loves punk rock", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 4, Name = "Bjork Gudmundsdottir", RoomNumber = "27", Notes = "Has an artistic flair", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 5, Name = "Sigur Ros", RoomNumber = "12", Notes = "Enjoys quiet environments", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 6, Name = "Annie Lennox", RoomNumber = "45", Notes = "Sings beautifully", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 7, Name = "David Bowie", RoomNumber = "33", Notes = "Loves stardust", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 8, Name = "Freddie Mercury", RoomNumber = "18", Notes = "Champions the world", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 9, Name = "Elvis Presley", RoomNumber = "22", Notes = "King of rock and roll", CareCenterId = 1 });
            modelBuilder.Entity<Resident>().HasData(new { ResidentId = 10, Name = "Aretha Franklin", RoomNumber = "29", Notes = "Queen of soul", CareCenterId = 1 });
            #endregion

            #region Medicine
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 1, Name = "Tyrol" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 2, Name = "Paracetamol" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 3, Name = "Ibuprofen" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 4, Name = "Aspirin" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 5, Name = "Amoxicillin" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 6, Name = "Ciprofloxacin" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 7, Name = "Metformin" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 8, Name = "Lisinopril" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 9, Name = "Simvastatin" });
            modelBuilder.Entity<Medicine>().HasData(new { MedicineId = 10, Name = "Omeprazole" });
            #endregion

            #region SubTask
            //When adding a new SubTask, remember to add a AssignmentId
            //modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 1, Name = "Giv vand",IsCompleted = false, AssignmentId = 1});
            #endregion

            #region MedicineTask
            //The medicineTaskId is the subtaskId that the medicineTask inherits from subtask
            //When adding a new SubTask, remember to add a MedicineAssignmentIds
            //modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 1,  MedicineId = 1, Amount = 2, Unit = "dl", IsCompleted = false, MedicineAssignmentId = 1 });
            #endregion

            #region Assignment
            //modelBuilder.Entity<Entities.Assignment>().HasData(new { AssignmentId = 1, TimeStart = DateTime.Now, TimeEnd = DateTime.Now.AddHours(2), ResidentId = 1, Notes = "Husk at give vand med medicinet", Completed = false });
            #endregion








            base.OnModelCreating(modelBuilder);
        }
    }   

}
