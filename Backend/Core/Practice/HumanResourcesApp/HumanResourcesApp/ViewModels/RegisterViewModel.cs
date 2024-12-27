using System.ComponentModel.DataAnnotations;

namespace HumanResourcesApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}

