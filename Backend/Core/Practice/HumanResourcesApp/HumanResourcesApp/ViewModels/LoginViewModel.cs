using System.ComponentModel.DataAnnotations;

namespace HumanResourcesApp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        [Length(
            minimumLength: 5,
            maximumLength: 12,
            ErrorMessage = "Username length should be between 5 and 12 characters")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
