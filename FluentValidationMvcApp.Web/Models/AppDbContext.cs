using Microsoft.EntityFrameworkCore;

namespace FluentValidationMvcApp.Web.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
