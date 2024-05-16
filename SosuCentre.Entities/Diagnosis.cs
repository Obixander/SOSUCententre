using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SosuCentre.Entities
{
    public class Diagnosis
    {

        #region Properties
        [Key]
        public int DiagnosisId
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
        
        public string Description
        {
            get;
            set;
        }

        #endregion
    }
}
