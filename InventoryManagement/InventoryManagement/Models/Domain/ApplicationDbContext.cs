using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Models.Domain
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts):base(opts)
        {
        
        }

        public DbSet<Item> Items { get; set; }

    }
}
