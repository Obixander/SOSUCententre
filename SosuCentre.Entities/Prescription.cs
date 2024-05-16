using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SosuCentre.Entities
{
    public class Prescription
    {


        #region Properties
        [Key]
        public int PrescriptionId
        {
            get;
            set;
        }
        [Required]
        public int Name
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public string Unit
        {
            get;
            set;
        }

        #endregion
    }
}
