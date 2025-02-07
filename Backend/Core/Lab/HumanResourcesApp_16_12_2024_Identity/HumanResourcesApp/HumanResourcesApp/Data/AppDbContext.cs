using HumanResourcesApp.Areas.Accounting.Models;
using HumanResourcesApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;   // for DbContext Class
using Microsoft.EntityFrameworkCore;



namespace HumanResourcesApp.Data
{
    // public class AppDbContext : DbContext
    public class AppDbContext : IdentityDbContext   // Identity - Step 2
    {
        #region Fields
        private string _myField;
        #endregion
        #region Properties

        #region Constructors
        // DbContextOptions creates an instance of this class (AppDbContext)
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        #endregion

        public DbSet<Department> Departments { get; set; }  // same as the table name - Plural and PascalCase. 
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Payroll> Payrolls { get; set; }

        public DbSet<AccountingPayroll> AccountingPayrolls { get; set; }
        #endregion

    }
}
