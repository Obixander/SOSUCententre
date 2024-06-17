using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class Medicine
    {
        private int medicineId;
        private string name;

        public Medicine(int medicineId, string name)
        {
            MedicineId = medicineId;
            Name = name;
        }

        public Medicine()
        {
            
        }

        #region Properties

        public int MedicineId
        {
            get => medicineId;
            set => medicineId = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        #endregion
    }
}
