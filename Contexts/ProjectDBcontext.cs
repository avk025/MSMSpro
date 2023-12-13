using Microsoft.EntityFrameworkCore;
using MSMSwebapipro.Models;

namespace MSMSwebapipro.Contexts
{
    public class ProjectDBcontext : DbContext
    { 
        public ProjectDBcontext(DbContextOptions<ProjectDBcontext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
