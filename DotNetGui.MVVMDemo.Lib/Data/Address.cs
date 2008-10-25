using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGui.MVVMDemo.Lib.Data
{
    public class Address
    {
        public String Street { get; set; }
        public String StreetNumber { get; set; }
        public String Zip { get; set; }
        public String City { get; set; }
        public String Country { get; set; }

        public Address(string street, string streetNumber, string zip, string city)
        {
            Street = street;
            StreetNumber = streetNumber;
            Zip = zip;
            City = city;
        }

        public Address(string street, string streetNumber, string zip, string city, string country)
            : this(street, streetNumber, zip, city)
        {
            Country = country;
        }
    }
}
