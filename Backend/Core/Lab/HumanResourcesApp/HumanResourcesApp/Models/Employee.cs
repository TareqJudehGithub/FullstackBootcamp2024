using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesApp.Models
{

    public class Employee
    {
        // Data Annotation
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Employee ID")]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        [Column(TypeName = "NVARCHAR(50)")]
        public string EmployeeName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Employee Email")]
        [Column(TypeName = "VARCHAR(50)")]
        public string EmployeeEmail { get; set; }

        [Required]
        [Display(Name = "Department")]
        [Column(TypeName = "INT")]
        public int DepartmentId { get; set; } // DepartmentId foreign key 

        public Department Department { get; set; }    // Obj from Department class

        [Required]
        [Display(Name = "Hiring Date")]
        [Column(TypeName = "DATETIME")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime HiringDate { get; set; }

        [Required]
        [Display(Name = "Basic Salary")]
        [Column(TypeName = "DECIMAL(18,3)")]
        public decimal BasicSalary { get; set; }

    }
}
