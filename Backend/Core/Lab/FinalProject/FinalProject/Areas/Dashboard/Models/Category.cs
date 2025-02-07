using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Areas.Dashboard.Models
{
    [Table(name: "Categories", Schema = "dbo")]
    public class Category
    {
        [Key]   // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    // (1, 1)
        [Column(TypeName = "INT")]
        [Display(Name = "Category Id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}

