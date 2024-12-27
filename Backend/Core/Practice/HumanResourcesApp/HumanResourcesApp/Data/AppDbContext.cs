// Ignore Spelling: App

using HumanResourcesApp.Areas.Accounting.Models;
using HumanResourcesApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;   // for DbContext Class



namespace HumanResourcesApp.Data
{
    public class AppDbContext : IdentityDbContext
    {

        #region Constructors
        // DbContextOptions creates an instance of this class (AppDbContext)
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        #endregion

        #region Properties
        // same as the table name - Plural and PascalCase. 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<AccPayroll> AccPayrolls { get; set; }
        #endregion
    }
}
