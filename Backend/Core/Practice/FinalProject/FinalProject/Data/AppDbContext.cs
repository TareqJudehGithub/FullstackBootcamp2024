using FinalProject.Areas.Dashboard.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class AppDbContext : IdentityDbContext
    {
        #region Constructors
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        #endregion

        #region Properties
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        #endregion
    }
}
