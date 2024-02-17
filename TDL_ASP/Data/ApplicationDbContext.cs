using Microsoft.EntityFrameworkCore;
using TDL_ASP.Models;

namespace TDL_ASP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ToDoTask> Tasks { get; set; }
    }
}
