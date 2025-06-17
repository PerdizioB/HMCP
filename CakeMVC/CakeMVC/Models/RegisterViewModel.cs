using System.ComponentModel.DataAnnotations;

namespace CakeMVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]

        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password didn't matched")]

        public string? ConfirmPassword { get; set; }


    }
}
