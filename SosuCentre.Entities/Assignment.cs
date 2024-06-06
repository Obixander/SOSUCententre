
namespace SosuCentre.Entities
{
    public class Assignment
    {

        #region Properties        
        public int AssignmentId
        {
            get;
            set;
        }

        public DateTime TimeStart
        {
            get;
            set;
        }
        public DateTime TimeEnd
        {
            get;
            set;
        }
        public Resident Resident
        {
            get;
            set;
        }

        public ICollection<Employee> Employees 
        {
            get;
            set;
        }
        public List<SubTask> SubTasks
        {
            get;
            set;
        }
        public List<MedicineTask> MedicineTasks
        {
            get;
            set;
        }

        //These might be needed later i dont know yet

        public string? Notes
        {
            get;
            set;
        }

        public bool Completed
        {
            get;
            set;
        }

        #endregion
    }
}