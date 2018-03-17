using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests_PersonAdvanced
{
    class PersonAdvanced
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public object Gender { get; set; }
        public DateTime Birthday { get; set; }
        public Address Address { get; set; }
        public PersonAdvanced Spouse { get; set; }
        public PersonAdvanced[] Children { get; set; }
    }
    class Gender
    {
        public static object Male { get; set; }
        public static object Female { get; set; }
    }
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int LocalNumber { get; set; }
    }
}
