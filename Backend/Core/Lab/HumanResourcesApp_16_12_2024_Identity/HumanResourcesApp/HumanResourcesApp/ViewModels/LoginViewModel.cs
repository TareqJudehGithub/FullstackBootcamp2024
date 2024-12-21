using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesApp.ViewModels
{
    public class LoginViewModel
    {
        #region Properties
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        #endregion
    }
}
