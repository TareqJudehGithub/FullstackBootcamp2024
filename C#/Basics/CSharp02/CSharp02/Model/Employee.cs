using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp02.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public decimal SSC { get; set; }

        #region Methods
        public decimal CalculateSalary(Employee employee)
        {
            decimal totalSalary = employee.Salary + employee.Bonus - employee.SSC;
            return totalSalary;
        }

        #endregion

        public int CalculateAge(Employee employee)
        {
            int empAge = DateTime.Now.Year - employee.DOB.Year;
            return empAge;
        }

    }
}
