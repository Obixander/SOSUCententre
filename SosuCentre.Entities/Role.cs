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
        [Key]
        public int RoleId
        {
            get;
            set;
        }
        [Required]
        public string RoleName
        {
            get;
            set;
        }
        #endregion
    }
}
