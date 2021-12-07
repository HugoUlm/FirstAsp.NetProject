using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class LogInViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Email or password was wrong.")]
        public string Password { get; set; }
    }
}
