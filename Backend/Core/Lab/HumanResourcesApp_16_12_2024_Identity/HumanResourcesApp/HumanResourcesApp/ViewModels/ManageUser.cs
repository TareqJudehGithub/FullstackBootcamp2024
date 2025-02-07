using System.ComponentModel.DataAnnotations;

namespace HumanResourcesApp.ViewModels
{
    public class ManageUser
    {
        [Display(Name = "User Id")]
        public string? Id { get; set; }

        [Required]
        [Display(Name = "User Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "User Phone #")]
        public string PhoneNumber { get; set; }
    }
}
