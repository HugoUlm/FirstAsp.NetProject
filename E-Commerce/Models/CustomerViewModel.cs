using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class CustomerViewModel
    {
        [DisplayName("Email address")]
        [Required(ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter a password.")]
        public string Password { get; set; }
        [DisplayName("First name")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Place enter your date of birth.")]
        public DateTime Birth { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Please enter which country you're from.")]
        public string Country { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Please enter your gender.")]
        public string Gender { get; set; }
    }
}

