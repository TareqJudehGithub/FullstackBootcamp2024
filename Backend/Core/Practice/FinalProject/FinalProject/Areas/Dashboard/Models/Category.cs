using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Areas.Dashboard.Models
{
    [Table(name: "Categories", Schema = "dbo")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Display(Name = "Category Name")]
        [StringLength(
            50,
            MinimumLength = 3,
            ErrorMessage = "Category Name should be between 3 - 50 characters.")]
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

    }
}
