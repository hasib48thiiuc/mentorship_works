using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public class SoldItemRepository:Repository<StockOutItem>,ISoldItemRepository
    {
        public SoldItemRepository(ApplicationDbContext ctx): base(ctx) 
        { 
        
        }


    }
}
