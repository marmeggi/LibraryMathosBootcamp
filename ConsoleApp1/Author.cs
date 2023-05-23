using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Author
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string CityOfBirth { get; set; }
        public string CountryOfBirth { get; set; }

        public Author(string firstName, string lastName, DateTime dateOfBirth, DateTime dateOfDeath, string CityOfBirth, string CountryOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.DateOfDeath = DateOfDeath;
            this.CityOfBirth = CityOfBirth;
            this.CountryOfBirth = CountryOfBirth;
        }
    }
}
