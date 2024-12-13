using System.ComponentModel;

namespace HumanResourcesApp.ViewModels
{
    public class EmployeeReportViewModel
    {
        [DisplayName("Employees Total")]
        public int EmployeeCount { get; set; }

        [DisplayName("SSA Total")]
        public decimal TotalSSA { get; set; }

        [DisplayName("Basic Salaries Total")]
        public decimal TotalBasicSalries { get; set; }

        [DisplayName("Bonuses Total")]
        public decimal TotalBonuses { get; set; }

        [DisplayName("Net Salaries Total")]
        public decimal TotalNetSalaries { get; set; }
    }
}
