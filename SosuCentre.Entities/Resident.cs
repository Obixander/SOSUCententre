using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class Resident
    {


        #region Properties
        public int ResidentId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
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
