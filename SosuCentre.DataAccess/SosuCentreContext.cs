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
            modelBuilder.Entity<MedicineTask>().Property("AssignmentId").HasColumnName("MedicineAssignmentId");

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
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 1, Name = "Giv vand", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 2, Name = "Hjælp med medicin", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 3, Name = "Planlægning af måltider", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 4, Name = "Overvågning af helbred", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 5, Name = "Transport til aftaler", IsCompleted = false, AssignmentId = 2 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 6, Name = "Rengøring", IsCompleted = false, AssignmentId = 2 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 7, Name = "Indkøb", IsCompleted = false, AssignmentId = 3 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 8, Name = "Social kontakt", IsCompleted = false, AssignmentId = 3 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 9, Name = "Assistance med daglig pleje", IsCompleted = false, AssignmentId = 3 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 10, Name = "Hjælp med regninger", IsCompleted = false, AssignmentId = 4 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 11, Name = "Planlægning af aktiviteter", IsCompleted = false, AssignmentId = 4 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 12, Name = "Hjælp med teknologi", IsCompleted = false, AssignmentId = 4 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 13, Name = "Følelsesmæssig støtte", IsCompleted = false, AssignmentId = 5 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 14, Name = "Koordinering med sundhedstjenester", IsCompleted = false, AssignmentId = 5 });
            modelBuilder.Entity<SubTask>().HasData(new { SubTaskId = 15, Name = "Støtte til mobilitet", IsCompleted = false, AssignmentId = 5 });
            #endregion

            #region MedicineTask
            //When adding a new MediciineTask, remember to add a AssignmentId with in the database is "MedicineAssignmentId"
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 1, Name = "PlaceHolder", MedicineId = 7, Amount = 2.0, Unit = "dl", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 2, Name = "PlaceHolder", MedicineId = 3, Amount = 1.0, Unit = "tablet", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 3, Name = "PlaceHolder", MedicineId = 9, Amount = 5.0, Unit = "ml", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 4, Name = "PlaceHolder", MedicineId = 2, Amount = 2.5, Unit = "g", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 5, Name = "PlaceHolder", MedicineId = 10, Amount = 10.0, Unit = "mg", IsCompleted = false, AssignmentId = 1 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 6, Name = "PlaceHolder", MedicineId = 1, Amount = 20.0, Unit = "ml", IsCompleted = false, AssignmentId = 2 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 7, Name = "PlaceHolder", MedicineId = 6, Amount = 0.5, Unit = "l", IsCompleted = false, AssignmentId = 2 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 8, Name = "PlaceHolder", MedicineId = 8, Amount = 15.0, Unit = "units", IsCompleted = false, AssignmentId = 3 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 9, Name = "PlaceHolder", MedicineId = 4, Amount = 1.5, Unit = "teaspoon", IsCompleted = false, AssignmentId = 3 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 10, Name = "PlaceHolder", MedicineId = 5, Amount = 3.0, Unit = "tablespoon", IsCompleted = false, AssignmentId = 3 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 11, Name = "PlaceHolder", MedicineId = 2, Amount = 30.0, Unit = "ml", IsCompleted = false, AssignmentId = 4 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 12, Name = "PlaceHolder", MedicineId = 7, Amount = 50.0, Unit = "mg", IsCompleted = false, AssignmentId = 4 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 13, Name = "PlaceHolder", MedicineId = 3, Amount = 4.0, Unit = "capsules", IsCompleted = false, AssignmentId = 4 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 14, Name = "PlaceHolder", MedicineId = 1, Amount = 0.25, Unit = "liters", IsCompleted = false, AssignmentId = 5 });
            modelBuilder.Entity<MedicineTask>().HasData(new { MedicineTaskId = 15, Name = "PlaceHolder", MedicineId = 5, Amount = 75.0, Unit = "units", IsCompleted = false, AssignmentId = 5 });
            #endregion

            #region Assignment
            modelBuilder.Entity<Entities.Assignment>().HasData(new { AssignmentId = 1, TimeStart = DateTime.Now, TimeEnd = DateTime.Now.AddHours(2), ResidentId = 1, Notes = "PlaceHolder", Completed = false });
            modelBuilder.Entity<Entities.Assignment>().HasData(new { AssignmentId = 2, TimeStart = DateTime.Now.AddHours(2), TimeEnd = DateTime.Now.AddHours(3), ResidentId = 1, Notes = "PlaceHolder", Completed = false });
            modelBuilder.Entity<Entities.Assignment>().HasData(new { AssignmentId = 3, TimeStart = DateTime.Now.AddHours(3), TimeEnd = DateTime.Now.AddHours(5), ResidentId = 1, Notes = "PlaceHolder", Completed = false });
            modelBuilder.Entity<Entities.Assignment>().HasData(new { AssignmentId = 4, TimeStart = DateTime.Now.AddHours(6), TimeEnd = DateTime.Now.AddHours(9), ResidentId = 1, Notes = "PlaceHolder", Completed = false });
            modelBuilder.Entity<Entities.Assignment>().HasData(new { AssignmentId = 5, TimeStart = DateTime.Now.AddHours(9), TimeEnd = DateTime.Now.AddHours(11), ResidentId = 1, Notes = "PlaceHolder", Completed = false });


            #endregion








            base.OnModelCreating(modelBuilder);
        }
    }   

}
