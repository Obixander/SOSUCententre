using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SosuCentre.Entities
{
    public class Employee
    {
       
        #region Properties
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }
        
        public ICollection<Task> Tasks
        {
            get;
            set;
        }
        [Required]
        public ICollection<Role> Role
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
        public CareCenter CareCenter
        {
            get;
            set;
        }

        #endregion
    }
}
