using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public List<Category> GetCategoryByCompany(int id)
        {
            List<Category> categories = _ctx.Categories.Where(categories => categories.Id == id).ToList();

            return categories;
        }
    }
}
