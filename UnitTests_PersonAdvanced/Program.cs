using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests_PersonAdvanced
{
    class Program
    {
        public static PersonAdvanced JohnSmith = new PersonAdvanced
        {
            Name = "John",
            Surname = "Smith",
            Gender = Gender.Male,
            Birthday = new DateTime(1972, 2, 2),
            Address = Address,
            Spouse = SussaneSmith,
            Children = new[] { MarrySmith, KewinSmith }
        };

        public static PersonAdvanced SussaneSmith = new PersonAdvanced
        {
            Name = "Sussane",
            Surname = "Smith",
            Gender = Gender.Female,
            Birthday = new DateTime(1976, 6, 6),
            Address = Address,
            Spouse = JohnSmith,
            Children = new[] { MarrySmith, KewinSmith }
        };

        public static PersonAdvanced KewinSmith = new PersonAdvanced
        {
            Name = "Kewin",
            Surname = "Smith",
            Gender = Gender.Male,
            Birthday = new DateTime(2001, 1, 1),
            Address = Address
        };

        public static PersonAdvanced MarrySmith = new PersonAdvanced
        {
            Name = "Mary",
            Surname = "Smith",
            Gender = Gender.Female,
            Birthday = new DateTime(2002, 2, 2),
            Address = Address
        };

        public static readonly Address Address = new Address
        {
            Country = "London",
            City = "London",
            ZIPCode = "W1T 1JY",
            Street = "Tottenham Court Road",
            StreetNumber = 14,
            LocalNumber = 1
        };

        static void Main(string[] args)
        {
        }
    }
}
