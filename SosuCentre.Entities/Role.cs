using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class Role
    {
        private int roleId;
        private string roleName;
        private List<Employee> employees;

        public Role(int roleId, string roleName, List<Employee> employees)
        {
            RoleId = roleId;
            RoleName = roleName;
            Employees = employees;
        }

        public Role()
        {
            
        }


        #region Properties
        public int RoleId
        {
            get => roleId;
            set => roleId = value;
        }
        public string RoleName
        {
            get => roleName;
            set => roleName = value;
        }

        public List<Employee> Employees
        {
            get => employees;
            set => employees = value;
        }
        #endregion
    }
}
