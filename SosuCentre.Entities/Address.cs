using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SosuCentre.Entities
{
    public class Address
    {       

        [Key]
        public int AddressId
        {
            get;
            set;
        }
        [Required]
        public string Street
        {
            get;
            set;
        }
        [Required]
        public string City
        {
            get;
            set;
        }
        [Required]
        public string State
        {
            get;
            set;
        }
        [Required]
        public string ZipCode
        {
            get;
            set;
        }

        
    }
}
