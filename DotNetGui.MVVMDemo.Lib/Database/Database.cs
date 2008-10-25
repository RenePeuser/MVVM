using System;
using System.Collections.Generic;
using System.Text;
using DotNetGui.MVVMDemo.Lib.Data;

namespace DotNetGui.MVVMDemo.Lib.Database
{
    public static class Database
    {
        public static Address[] GetAddresses()
        {
            Address[] address = new Address[]
            {
                new Address("Eine Strasse", "1", "10000", "Eine Stadt"),
                new Address("Eine andere Straße", "2", "20000", "Eine andere Stadt")
            };
            return address;
        }

        public static Person[] GetPeople()
        {
            Person[] people = new Person[]
            {
                new Person("Vorname 1", "Nachname 1"),
                new Person("Vorname 2", "Nachname 2")
            };
            return people;
        }

        public static Person[] GetCompletePeople()
        {
            Person[] p = GetPeople();
            Address[] a = GetAddresses();
            foreach (Person tempPerson in p)
                foreach (Address tempAddress in a)
                    tempPerson.Addresses.Add(tempAddress);
            return p;
        }
    } 
}
