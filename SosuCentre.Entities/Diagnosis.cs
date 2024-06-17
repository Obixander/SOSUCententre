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
        private int diagnosisId;
        private string name;
        private string description;

        public Diagnosis(int diagnosisId, string name, string description)
        {
            DiagnosisId = diagnosisId;
            Name = name;
            Description = description;
        }

        #region Properties
        public int DiagnosisId
        {
            get => diagnosisId;
            set => diagnosisId = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        #endregion
    }
}
