using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Areas.Dashboard.Models
{
    [Table(name: "Products", Schema = "dbo")]
    public class Product
    {
        [Key]   // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "INT")]
        [Display(Name = "Product Id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(256)")]
        [Length(
            minimumLength: 5,
            maximumLength: 256,
            ErrorMessage = "Description length should be between 5 - 256 characters.")
            ]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(18,3)")]
        [Display(Name = "Product Price")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(256)")]
        [Display(Name = "Product Image")]
        public string ImagePath { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
