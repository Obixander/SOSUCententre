using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SosuCentre.Entities
{
    public class Resident
    {


        #region Properties
        [Key]
        public int ResidentId
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
        public string RoomNumber
        {
            get;
            set;
        }

        public ICollection<Diagnosis> Diagnoses
        {
            get;
            set;
        }

        public ICollection<Prescription> Prescriptions
        {
            get;
            set;
        }

        public string Notes
        {
            get;
            set;
        }

        #endregion
    }
}
