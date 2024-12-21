using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesApp.Areas.Accounting.Models

{
    [Table("AccountingPayrolls", Schema = "dbo")]

    public class AccountingPayroll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        [Display(Name = "PayrollAmount")]
        [Column(TypeName = "DECIMAL(18,3)")]
        public decimal PayrollAmount { get; set; }

        [Display(Name = "Time Span")]
        [Column(TypeName = "DATETIME")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy:}")]
        public DateTime TS { get; set; }
    }
}
