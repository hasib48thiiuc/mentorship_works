using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }
    }
}
