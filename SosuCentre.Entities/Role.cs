using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SosuCentre.Entities
{
    public class Role
    {


        #region Properties
        public int RoleId
        {
            get;
            set;
        }
        public string RoleName
        {
            get;
            set;
        }

        public List<Employee> Employees
        {
            get;
            set;
        }
        #endregion
    }
}
