using System.ComponentModel.DataAnnotations;

namespace CakeMVC.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "E-mail is not valid")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remember Me")]

        public bool RememberMe { get; set; }


    }
}
