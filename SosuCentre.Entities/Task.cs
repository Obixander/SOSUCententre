using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SosuCentre.Entities
{
    public class Task
    {

        #region Properties

        [Key]
        public int TaskId
        {
            get;
            set;
        }
        [Required]
        public string Name
        {
            get;
            set;
        }
        [Required]
        public DateTime TimeStart
        {
            get;
            set;
        }
        [Required]
        public DateTime TimeEnd
        {
            get;
            set;
        }
        [Required]
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

        public ICollection<Medicine>? Medicines
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