using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetGui.MVVMDemo.Lib.Data
{
    public class Person
    {
        private List<Address> _addresses = new List<Address>();

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthday { get; set; }

        public IList<Address> Addresses
        {
            get { return _addresses; }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, DateTime birthDay)
            : this(firstName, lastName)
        {
            Birthday = birthDay;
        }
    }
}
