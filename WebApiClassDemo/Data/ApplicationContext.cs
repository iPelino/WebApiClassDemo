using Microsoft.EntityFrameworkCore;
using WebApiClassDemo.Models;

namespace WebApiClassDemo.Data;

public class ApplicationContext: DbContext
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
}

