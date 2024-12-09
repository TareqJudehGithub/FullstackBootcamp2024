using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesApp.Models
{
    [Table("Payrolls", Schema = "dbo")]
    public class Payroll
    {
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        [ForeignKey("EmployeeID")]
        [Required]
        [Column(TypeName = "INT")]
        [Display(Name = "Employee Name")]
        public int EmployeeID { get; set; }

        [Required]
        [Column(TypeName = "DATETIME")]
        [Display(Name = "Payroll Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime PayrollDate { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(18,3)")]
        [Display(Name = "Bonus")]
        public decimal Bonus { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(18,3)")]
        [Display(Name = "S.S. Amount")]
        public decimal SocialSecurityAmount { get; set; }

        [Required]
        [Column(TypeName = "FLOAT")]
        [Display(Name = "Leaves (In Hours)")]
        public float? Leaves { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(18,3)")]
        [Display(Name = "Net Salary")]
        public decimal NetSalary { get; set; }

        [Column(TypeName = "DATETIME")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Time Span")]
        public DateTime? TS { get; set; }


        [Column(TypeName = "NVARCHAR(50)")]
        [Display(Name = "Created By")]
        [StringLength(50)]
        [ReadOnly(true)]
        public string? CreatedBy { get; set; }

        [Display(Name = "Employee Name")]
        public Employee Employee { get; set; }
        #endregion
    }
}
