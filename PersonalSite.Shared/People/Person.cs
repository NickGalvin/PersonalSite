using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.People
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Address Address { get; set; }

        public static Person Me => new Person
        {
            Id = "1",
            Name = "Nick Galvin",
            Email = "nick.m.galvin@gmail.com",
            Phone = "651-230-0756",
            Address = new Address
            {
                Name = "Nick Galvin",
                Line1 = "1228 6th Ave S",
                City = "South Saint Paul",
                State = "MN",
                Zip = "55075",
                Country = "United States"
            }
        };
    }
}
