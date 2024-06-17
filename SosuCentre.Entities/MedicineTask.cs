using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class MedicineTask 
    {
        private int medicineTaskId;
        private string name;
        private bool isCompleted;
        private Medicine medicine;
        private double amount;
        private string unit;

        public MedicineTask(int medicineTaskId, string name, bool isCompleted, Medicine medicine, double amount, string unit)
        {
            MedicineTaskId = medicineTaskId;
            Name = name;
            IsCompleted = isCompleted;
            Medicine = medicine;
            Amount = amount;
            Unit = unit;
        }

        public int MedicineTaskId
        {
            get => medicineTaskId;
            set => medicineTaskId = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public bool IsCompleted
        {
            get => isCompleted;
            set => isCompleted = value;
        }

        public Medicine Medicine
        {
            get => medicine;
            set => medicine = value;
        }

        public double Amount
        {
            get => amount;
            set => amount = value;
        }

        public string Unit
        {
            get => unit;
            set => unit = value;
        }

    }
}
