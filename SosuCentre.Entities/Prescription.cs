using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class Prescription
    {


        #region Properties
        
        public int PrescriptionId
        {
            get;
            set;
        }
        
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
