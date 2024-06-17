using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SosuCentre.Entities
{
    public class Employee
    {
        private int employeeId;
        private ICollection<Assignment> tasks;
        private ICollection<Role> role;
        private string name;
        private CareCenter careCenter;

        public Employee(int employeeId, ICollection<Assignment> tasks, ICollection<Role> role, string name, CareCenter careCenter)
        {
            EmployeeId = employeeId;
            Tasks = tasks;
            Role = role;
            Name = name;
            CareCenter = careCenter;
        }

        #region Properties
        public int EmployeeId
        {
            get => employeeId;
            set => employeeId = value;
        }

        public ICollection<Assignment> Tasks
        {
            get => tasks;
            set => tasks = value;
        }
        public ICollection<Role> Role
        {
            get => role;
            set => role = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public CareCenter CareCenter
        {
            get => careCenter;
            set => careCenter = value;
        }

        #endregion
    }
}
