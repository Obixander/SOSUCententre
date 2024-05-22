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
        private int addressId;
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public Address()
        {
            
        }

        public int AddressId
        {
            get => addressId;
            set => addressId = value;
        }
        public string Street
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string ZipCode
        {
            get;
            set;
        }

        
    }
}
