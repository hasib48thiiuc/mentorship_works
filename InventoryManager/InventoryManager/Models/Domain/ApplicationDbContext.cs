using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Models.Domain
{
    public class ApplicationDbContext:DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
        {
              
        }


        public DbSet<Person> Persons { get; set; }




    }
}
