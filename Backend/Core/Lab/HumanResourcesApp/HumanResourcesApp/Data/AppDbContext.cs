using HumanResourcesApp.Models;
using Microsoft.EntityFrameworkCore;   // for DbContext Class


namespace HumanResourcesApp.Data
{
    public class AppDbContext : DbContext
    {
        #region Properties

        public DbSet<Department> Departments { get; set; }  // same as the table name - Plural and PascalCase.
        public DbSet<Employee> Employees { get; set; }
        #endregion

        #region Constructors
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        #endregion

    }
}
