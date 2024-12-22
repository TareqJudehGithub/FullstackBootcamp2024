using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesApp.Models
{
    public class Department
    {
        [Key]   // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    // (1, 1)
        [Column(TypeName = "INT")]
        [Display(Name = "Department ID")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        [Display(Name = "Dept. Name")]
        public string DepartmentName { get; set; }
    }
}

