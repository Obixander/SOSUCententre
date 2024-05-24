
namespace SosuCentre.Entities
{
    public class Task
    {

        #region Properties

        
        public int TaskId
        {
            get;
            set;
        }
        public string Name
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
        } = new List<Employee>();
        //This maybe cause problems
        public ICollection<Medicine> Medicines
        {
            get;
            set;
        }
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