using Microsoft.EntityFrameworkCore;

namespace Restor.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Employe> Employees { get; set; } = null!;
        public DbSet<Meal> Meals { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

            Database.EnsureCreated();
        }
    }
}
