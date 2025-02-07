using HumanResourcesAPI.Models;

using Microsoft.EntityFrameworkCore;   // for DbContext Class

namespace HumanResourcesAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Attendance> Attendances { get; set; }

    }
}
