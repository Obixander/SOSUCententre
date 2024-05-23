﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class Medicine
    {
  
        #region Properties

        public int MedicineId
        {
            get;
            set;
        }
        public string Name
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

        public bool Administered
        {
            get;
            set;
        }

        #endregion
    }
}
