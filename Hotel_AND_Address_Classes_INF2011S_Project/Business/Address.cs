using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiSystem.Business
{
    internal class Address
    {
        private string street;
        private string surburb;
        private string city;
        private int postalCode;

        public string getStreet
        {
            get { return street; }
            set { street = value; }
        }

        public string getSurburb
        {
            get { return surburb; }
            set { surburb = value; }
        }

        public string getCity
        {
            get { return city; }
            set { city = value; }
        }

        public int getPostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        // Constructor
        public Address(string street, string city, string surburb, int postalCode)
        {
            this.street = street;
            this.city = city;
            this.surburb = surburb;
            this.postalCode = postalCode;
        }

        // Override ToString method for a readable string representation
        public override string ToString()
        {
            return $"{street}, {city}, {surburb}, {postalCode}";
        }
    }
}
