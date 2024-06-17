
namespace SosuCentre.Entities
{
    public class Assignment
    {
        private int assignmentId;
        private DateTime timeStart;
        private DateTime timeEnd;
        private Resident resident;
        private ICollection<Employee> employees;
        private List<SubTask> subTasks;
        private List<MedicineTask> medicineTasks;
        private string notes;
        private string medicinNotes;
        private bool completed;

        public Assignment(int assignmentId, DateTime timeStart, DateTime timeEnd, Resident resident, ICollection<Employee> employees, List<SubTask> subTasks, List<MedicineTask> medicineTasks, string notes, string medicinNotes, bool completed)
        {
            AssignmentId = assignmentId;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employees = employees;
            SubTasks = subTasks;
            MedicineTasks = medicineTasks;
            Notes = notes;
            MedicinNotes = medicinNotes;
            Completed = completed;
        }
        
        #region Properties        
        public int AssignmentId
        {
            get => assignmentId;
            set => assignmentId = value;
        }

        public DateTime TimeStart
        {
            get => timeStart;
            set => timeStart = value;
        }
        public DateTime TimeEnd
        {
            get => timeEnd;
            set => timeEnd = value;
        }
        public Resident Resident
        {
            get => resident;
            set => resident = value;
        }

        public ICollection<Employee> Employees
        {
            get => employees;
            set => employees = value;
        }
        public List<SubTask> SubTasks
        {
            get => subTasks;
            set => subTasks = value;
        }
        public List<MedicineTask> MedicineTasks
        {
            get => medicineTasks;
            set => medicineTasks = value;
        }

        //These might be needed later i dont know yet
        public string? Notes
        {
            get => notes;
            set => notes = value;
        }

        public string? MedicinNotes
        {
            get => medicinNotes;
            set => medicinNotes = value;
        }


        public bool Completed
        {
            get => completed;
            set => completed = value;
        }

        #endregion
    }
}