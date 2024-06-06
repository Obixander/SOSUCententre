using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class MedicineTask : SubTask
    {        
        //public int MedicineTaskId
        //{
        //    get;
        //    set;
        //}

        public Medicine Medicine
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

    }
}
