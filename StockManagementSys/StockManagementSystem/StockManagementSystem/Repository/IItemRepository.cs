using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public interface IItemRepository:IRepository<Item>
    {
     
        IEnumerable<Item> GetAllInItem();
        
    }
}