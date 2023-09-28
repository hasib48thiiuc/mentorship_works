using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public interface IItemRepository:IRepository<Item>
    {
     
        IEnumerable<Item> GetAllInItem();
        IEnumerable<Item> GetItemByCompany(int id);



    }
}