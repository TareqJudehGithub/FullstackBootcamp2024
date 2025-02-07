using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourcesAPI.Models
{
    public class Attendance
    {
        // Id int
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        // Employee Id
        [Display(Name = "Employee Id")]
        [Column(TypeName = "INT")]
        public int EmployeeId { get; set; }

        // employeeName string
        [Required]
        [Display(Name = "Employee Name")]
        [Column(TypeName = "VARCHAR(50)")]
        public string EmployeeName { get; set; }

        // AttendDate
        [Required]
        [Display(Name = "Attend Date")]
        [Column(TypeName = "DATETIME")]
        public DateTime AttendDate { get; set; }

        // CheckIn
        [Required]
        [Display(Name = "Check In")]
        [Column(TypeName = "DATETIME")]
        public DateTime CheckIn { get; set; }

        // CheckOut
        [Required]
        [Display(Name = "Check Out")]
        [Column(TypeName = "DATETIME")]
        public DateTime CheckOut { get; set; }
    }
}
