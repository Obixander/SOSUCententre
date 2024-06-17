using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class Resident
    {
        private int residentId;
        private string name;
        private string roomNumber;
        private ICollection<Diagnosis> diagnoses;
        private ICollection<Prescription> prescriptions;
        private string notes;

        public Resident(int residentId, string name, string roomNumber, ICollection<Diagnosis> diagnoses, ICollection<Prescription> prescriptions, string notes)
        {
            ResidentId = residentId;
            Name = name;
            RoomNumber = roomNumber;
            Diagnoses = diagnoses;
            Prescriptions = prescriptions;
            Notes = notes;
        }

        public Resident()
        {
            
        }

        #region Properties
        public int ResidentId
        {
            get => residentId;
            set => residentId = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string RoomNumber
        {
            get => roomNumber;
            set => roomNumber = value;
        }

        public ICollection<Diagnosis> Diagnoses
        {
            get => diagnoses;
            set => diagnoses = value;
        }

        public ICollection<Prescription> Prescriptions
        {
            get => prescriptions;
            set => prescriptions = value;
        }

        public string Notes
        {
            get => notes;
            set => notes = value;
        }

        #endregion
    }
}
