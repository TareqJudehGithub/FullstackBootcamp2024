// Ignore Spelling: Acc App

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesApp.Areas.Accounting.Models
{
    [Table(name: "AccPayroll", Schema = "dbo")]
    public class AccPayroll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "INT")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(18,3)")]
        [Display(Name = "Payroll Amount")]
        [Range(
            minimum: 1,
            maximum: double.MaxValue,
            ErrorMessage = "Payroll Amount cannot be zero")
        ]
        public decimal PayrollAmount { get; set; }

        [Column(TypeName = "DATETIME")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Time Span")]
        public DateTime? TS { get; set; }
    }
}
