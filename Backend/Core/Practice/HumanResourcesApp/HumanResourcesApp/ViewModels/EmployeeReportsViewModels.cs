using System.ComponentModel.DataAnnotations;

namespace HumanResourcesApp.ViewModels
{
    public class EmployeeReportsViewModels
    {
        /* In ViewModel we can add annotations that are not directly related
         * to the DB schema
         */
        [Display(Name = "Employees Total")]
        public int EmployeeCount { get; set; }

        [Display(Name = "Total SSA")]
        public decimal TotalSSA { get; set; }

        [Display(Name = "Total Basic Salaries")]
        public decimal TotalBasicSalaries { get; set; }

        [Display(Name = "Total Bonuses")]
        public decimal TotalBonuses { get; set; }

        [Display(Name = "Total Net Salaries")]
        public decimal TotalNetSalary { get; set; }

    }
}
