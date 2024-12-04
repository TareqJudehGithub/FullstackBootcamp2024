
using System.ComponentModel.DataAnnotations;
namespace Students.Models
{
    public class Student
    {
        [Required]
        [Display(Name = "Stu Id")]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [MaxLength(30)]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string StudentEmail { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        [Range(1, 10)]
        public string StudentNationality { get; set; }


        [Required]
        [Display(Name = "City")]
        [MaxLength(6)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Address")]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]

        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "High School")]
        public string HighSchool { get; set; }
    }
}


