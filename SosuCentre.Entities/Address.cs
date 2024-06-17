using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SosuCentre.Entities
{

    public class Address
    {
        private int addressId;
        private string street;
        private string city;
        private string state;
        private string zipCode;

      
        public Address()
        {
            
        }

        public Address(int addressId, string street, string city, string state, string zipCode)
        {
            AddressId = addressId;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public int AddressId
        {
            get => addressId;
            set => addressId = value;
        }
        public string Street
        {
            get => street;
            set => street = value;
        }
        public string City
        {
            get => city;
            set => city = value;
        }
        public string State
        {
            get => state;
            set => state = value;
        }
        public string ZipCode
        {
            get => zipCode;
            set => zipCode = value;
        }


    }
}
