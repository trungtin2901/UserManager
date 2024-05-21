using System.ComponentModel.DataAnnotations;

namespace EUserManager.Models
{
    public class RegisterRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
    }
}
