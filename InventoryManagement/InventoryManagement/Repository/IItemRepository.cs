using InventoryManagement.Models.Domain;

namespace InventoryManagement.Repository
{
    public interface IItemRepository
    {
        void AddItem(Item item);
        void DeleteItem(Item item);
        void EditItem(Item item);
        Item FindItem(int id);
        void SaveItem();
        IEnumerable<Item> ShowItem();
    }
}