using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public class ItemRepository :Repository<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public IEnumerable<Item> GetAllInItem()
        {
            IEnumerable<Item> items= _ctx.Items.Include(x=>x.Category).Include(x=>x.Company).ToList();
            return items;
        }
  
     // 01843396801
s
       
     
    }
}
