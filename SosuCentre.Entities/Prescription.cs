using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class Prescription
    {
        private int prescriptionId;
        private int name;
        private int amount;
        private string unit;

        public Prescription(int prescriptionId, int name, int amount, string unit)
        {
            PrescriptionId = prescriptionId;
            Name = name;
            Amount = amount;
            Unit = unit;
        }

        public Prescription()
        {
            
        }

        #region Properties

        public int PrescriptionId
        {
            get => prescriptionId;
            set => prescriptionId = value;
        }

        public int Name
        {
            get => name;
            set => name = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public string Unit
        {
            get => unit;
            set => unit = value;
        }

        #endregion
    }
}
