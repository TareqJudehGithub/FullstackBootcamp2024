using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HumanResourcesApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]    // Compare with Password
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
      
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
