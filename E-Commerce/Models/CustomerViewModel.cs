using System;
using E_Commerce.Models.Enumerations;

namespace E_Commerce.Models
{
    public class CustomerViewModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; } // Hash password in db adn de-hash on login
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birth { get; set; }
        public CountryViewModel Country { get; set; }
        public GenderEnumeration Gender { get; set; }
    }
}

