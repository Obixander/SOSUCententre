﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SosuCentre.Entities
{
    public class CareCenter
    {


        #region Properties

        [Key]
        public int CareCenterId
        {
            get;
            set;
        }
        [Required]
        public string Name
        {
            get;
            set;
        }
        [Required]
        public Address Address
        {
            get;
            set;
        }
        [Required]
        public ICollection<Resident> Residents
        {
            get;
            set;
        }

        #endregion
    }
}