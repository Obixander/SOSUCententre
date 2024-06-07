using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class MedicineTask 
    {
        public int MedicineTaskId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public bool IsCompleted
        {
            get;
            set;
        }

        public Medicine Medicine
        {
            get;
            set;
        }

        public double Amount
        {
            get;
            set;
        }

        public string Unit
        {
            get;
            set;
        }

    }
}
