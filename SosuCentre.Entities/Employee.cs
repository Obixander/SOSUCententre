using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SosuCentre.Entities
{
    public class Employee
    {
       
        #region Properties
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
        public ICollection<Role> Role
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public CareCenter CareCenter
        {
            get;
            set;
        }

        #endregion
    }
}
