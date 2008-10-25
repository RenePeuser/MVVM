using System;
using System.Collections.Generic;
using System.Text;
using DotNetGui.MVVMDemo.Lib.Data;

namespace DotNetGui.MVVMDemo.PeopleList.ViewModel
{
    public class AddressViewModel
    {
        private Address _address;

        public AddressViewModel(Address address)
        {
            _address = address;
        }

        public String Street
        {
            get { return _address.Street; }
            set { _address.Street = value; }
        }

        public String StreetNumber
        {
            get { return _address.StreetNumber; }
            set { _address.StreetNumber = value; }
        }

        public String Zip
        {
            get { return _address.Zip; }
            set { _address.Zip = value; }
        }

        public String City
        {
            get { return _address.City; }
            set { _address.City = value; }
        }

        public String Country
        {
            get { return _address.Country; }
            set { _address.Country = value; }
        }
    }
}
