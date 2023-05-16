using LinqAspCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqAspCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<State>? States { get; set; }
    }
}
