using Microsoft.EntityFrameworkCore;

namespace BookMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }

        public DbSet<Book> Books { get; set;}
    }
}
